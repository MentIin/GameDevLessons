using UnityEngine;

public class CameraController : MonoBehaviour
{

    // Update is called once per frame
    void LateUpdate()
    {
        // Rotate the camera based on mouse movement
        transform.Rotate(Vector3.up, Input.mousePositionDelta.x * 0.1f, Space.World);
        transform.Rotate(Vector3.left, Input.mousePositionDelta.y * 0.1f, Space.Self);
        
        
        
        
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
