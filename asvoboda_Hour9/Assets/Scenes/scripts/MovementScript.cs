using UnityEngine;

public class MovementScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Capture mouse movement and scale it down
        float mX = Input.GetAxis("Mouse X") / 10;
        float mY = Input.GetAxis("Mouse Y") / 10;

        // Move the object based on mouse input
        transform.Translate(mX, mY, 0);
    }
}