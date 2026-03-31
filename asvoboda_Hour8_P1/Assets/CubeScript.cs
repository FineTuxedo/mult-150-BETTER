using UnityEngine;

public class CubeScript : MonoBehaviour
{
    void Update()
    {
        // 1. Moves the cube .05 units every frame along the X axis
        transform.Translate(.05f, 0f, 0f);

        // 2. Rotates the cube 1 degree every frame around the Z axis
        transform.Rotate(0f, 0f, 1f);

        // 3. Sets the scale to 1.5x the original size
        // Note: This stays at 1.5; it doesn't keep growing every frame!
        transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
    }
}