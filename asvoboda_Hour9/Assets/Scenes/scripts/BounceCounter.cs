using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    int count = 0;

    void OnCollisionEnter(Collision collision)
    {
        count++;
        Debug.Log("Bounce count: " + count);
    }
}