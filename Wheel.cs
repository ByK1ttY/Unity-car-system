using UnityEngine;

public class Wheel : MonoBehaviour
{
    public Transform axle;
    public float maxAngle = 30f;
    public float rotateSpeed = 5f;

    private void FixedUpdate()
    {
        float rotateAngle = Mathf.Clamp(axle.localEulerAngles.y, -maxAngle, maxAngle);
        Quaternion targetRotation = Quaternion.Euler(0, rotateAngle, 0);
        axle.localRotation = Quaternion.Lerp(axle.localRotation, targetRotation, rotateSpeed * Time.fixedDeltaTime);
    }
}