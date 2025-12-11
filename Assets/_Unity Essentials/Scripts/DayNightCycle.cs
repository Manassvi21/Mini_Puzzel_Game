using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Duration of a full day in seconds.")]
    public float dayDurationInSeconds = 30f;

    void Update()
    {
        float rotationSpeed = 360f / dayDurationInSeconds;
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
    }
}
