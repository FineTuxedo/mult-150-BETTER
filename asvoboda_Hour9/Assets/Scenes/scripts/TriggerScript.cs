using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    // This runs the moment the sphere touches the cube
    void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name + " has entered the cube");
    }

    // This runs every frame the sphere remains inside the cube
    void OnTriggerStay(Collider other)
    {
        print(other.gameObject.name + " is still in the cube");
    }

    // This runs the moment the sphere leaves the cube
    void OnTriggerExit(Collider other)
    {
        print(other.gameObject.name + " has left the cube");
    }
}