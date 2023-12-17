using UnityEngine;

public class VehicleController : MonoBehaviour
{
    public float maxSpeed = 5f;
    public float speedMultiplier = 1f;
    public float rotateSpeed = 1f;
    public float frenSpeed = 1f;
    public float backSpeed = 1f;
    public float driftSpeed = 1f;
    public Wheel[] wheels;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.LeftShift))
        {
            foreach (Wheel wheel in wheels)
            {
                wheel.axle.localEulerAngles = new Vector3(0, 0, wheel.axle.localEulerAngles.z + horizontal * rotateSpeed * Time.fixedDeltaTime);
            }
        }
        else
        {
            float targetSpeed = vertical * maxSpeed * speedMultiplier;
            float speedChange = (targetSpeed - rb.velocity.magnitude) * Time.fixedDeltaTime;
            rb.velocity += rb.velocity.normalized * speedChange;
        }

        if (Input.GetKey(KeyCode.A))
        {
            foreach (Wheel wheel in wheels)
            {
                wheel.axle.localEulerAngles = new Vector3(0, 0, wheel.axle.localEulerAngles.z - rotateSpeed * Time.fixedDeltaTime);
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            foreach (Wheel wheel in wheels)
            {
                wheel.axle.localEulerAngles = new Vector3(0, 0, wheel.axle.localEulerAngles.z + rotateSpeed * Time.fixedDeltaTime);
            }
        }

        if (Input.GetKey(KeyCode.W))
        {
            foreach (Wheel wheel in wheels)
            {
                wheel.axle.localEulerAngles = new Vector3(0, 0, wheel.axle.localEulerAngles.z + rotateSpeed * Time.fixedDeltaTime);
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            foreach (Wheel wheel in wheels)
            {
                wheel.axle.localEulerAngles = new Vector3(0, 0, wheel.axle.localEulerAngles.z - rotateSpeed * Time.fixedDeltaTime);
            }
        }

        if (Input.GetKey(KeyCode.LeftControl))
        {
            foreach (Wheel wheel in wheels)
            {
                wheel.axle.localEulerAngles = new Vector3(0, 0, wheel.axle.localEulerAngles.z + rotateSpeed * Time.fixedDeltaTime);
            }
        }
    }
}