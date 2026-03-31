using UnityEngine;

public class LightScript : MonoBehaviour
{
    private Light lightComponent;

    void Start()
    {
        // Grab the Light component once at the start
        lightComponent = GetComponent<Light>();
    }

    void Update()
    {
        // If the 'L' key is JUST pressed down
        if (Input.GetKeyDown(KeyCode.L))
        {
            // The '!' operator flips the value (True becomes False, vice versa)
            lightComponent.enabled = !lightComponent.enabled;
            
            Debug.Log("Light toggled!");
        }
    }
}