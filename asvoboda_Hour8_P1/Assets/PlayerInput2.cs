using UnityEngine;

public class PlayerInput2 : MonoBehaviour
{
    void Update()
    {
        // 1. Get the mouse movement values (X is left/right, Y is up/down)
        float mxVal = Input.GetAxis("Mouse X");
        float myVal = Input.GetAxis("Mouse Y");

        // 2. If the mouse moved on the X axis, print the value
        if (mxVal != 0)
        {
            print("Mouse X movement selected: " + mxVal);
        }

        // 3. If the mouse moved on the Y axis, print the value
        if (myVal != 0)
        {
            print("Mouse Y movement selected: " + myVal);
        }
    }
}