using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform target;
    float cameraSlerpSpeed = 0.1f;

    void Update()
    {
        Vector3 targetCameraPosition = new Vector3(target.position.x + 4, transform.position.y, target.position.z - 4);
        transform.position = Vector3.Slerp(transform.position, targetCameraPosition, cameraSlerpSpeed);
    }
}
