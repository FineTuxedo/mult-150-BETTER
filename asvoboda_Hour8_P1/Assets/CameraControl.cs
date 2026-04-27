using UnityEngine;

public class CameraControl : MonoBehaviour
{
    void Update()
    {
        // Get mouse movement
        float xMove = Input.GetAxis("Mouse X");
        float yMove = Input.GetAxis("Mouse Y");

        // Translate the camera left/right (X) and up/down (Y)
        // Adjust the .1f to change how fast the camera slides
        transform.Translate(xMove * 0.1f, yMove * 0.1f, 0f);
    }
}

