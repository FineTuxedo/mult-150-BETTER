using UnityEngine;

public class TargetCubeScript : MonoBehaviour
{
    // 1. Create a variable to hold the object we want to control
    private GameObject target;

    void Start()
    {
        // 2. Tell Unity to go find the object named "Cube" in the scene
        target = GameObject.Find("Cube");
    }

    void Update()
    {
        // 3. Instead of transform.Translate (which moves the Camera), 
        // we use target.transform.Translate to move the Cube.
        target.transform.Translate(.05f, 0f, 0f);
        target.transform.Rotate(0f, 0f, 1f);
        target.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
    }
}
