using UnityEngine;
//Base class
public class Vehicles : MonoBehaviour
{
    [Header("Set Boolean corresponding to the vehicle:")]
    [SerializeField] protected bool isFlyable;
    [SerializeField] protected bool isAutoThruster;
    [SerializeField] protected bool isfloatable;
    [Header("Add extra power or force:")]
    [SerializeField] float addManualthruster;
    [SerializeField] float addRollforce;
    [SerializeField] float addYawForce;
    [SerializeField] float addPitchForce;
    [SerializeField] float addAutoForce;
    [Header("Set local boundary:")]
    [SerializeField] float maxX;
    [SerializeField] float minX;
    [SerializeField] float maxY;
    [SerializeField] float minY;
    [SerializeField] float maxZ;
    [SerializeField] float minZ;
    [Header("Read both mouse and keyboard axis input:")]
    [SerializeField] float _yaw;
    [SerializeField] float _pitch;
    [SerializeField] float _roll;
    [SerializeField] float _forwardMov;

    //encapsulation
    public float Yaw { get => _yaw; private set => _yaw = value; }
    public float Pitch { get => _pitch; private set => _pitch = value; }
    public float Roll { get => _roll; private set => _roll = value; }
    public float ForwardMov { get => _forwardMov; private set => _forwardMov = value; }

    //overloading
    protected void Move(float roll, float forwardMov)
    {
        transform.Translate(new Vector3(0.0f, 0.0f, forwardMov) * Time.deltaTime * addManualthruster);
        transform.Rotate(0.0f, roll * Time.deltaTime * addRollforce, 0.0f);
    }
    protected void Move(float pitch, float yaw, float roll, float forwardMov)
    {
        transform.Translate(new Vector3(0.0f, 0.0f, forwardMov) * Time.deltaTime * addManualthruster);
        transform.Rotate(pitch * addPitchForce, yaw * Time.deltaTime * addYawForce, -roll * Time.deltaTime * addRollforce);
    }
    protected void SetBoundary()
    {
        transform.localPosition = new Vector3(Mathf.Clamp(transform.localPosition.x, minX, maxX), Mathf.Clamp(transform.localPosition.y, minY, maxY), Mathf.Clamp(transform.localPosition.z, minZ, maxZ));
    }
    protected void GetInputMoveMent()
    {
        _yaw = Input.GetAxis("Mouse X");
        _pitch = Input.GetAxis("Mouse Y") * -1;
        _roll = Input.GetAxis("Horizontal");

        if (isAutoThruster)
        {
            _forwardMov = addAutoForce;
        }

        if (isFlyable && !isAutoThruster)
        {
            _forwardMov = Input.GetAxis("Vertical");
            if (_forwardMov < 0)
            {
                _forwardMov = 0;
            }
        }

        if (!isFlyable && !isAutoThruster)
        {
            if (!isfloatable && _forwardMov == 0)
            {
                _roll = 0;
            }
            if (_forwardMov < 0)
            {
                _roll *= -1;
            }
            _forwardMov = Input.GetAxis("Vertical");
        }
    }
}
