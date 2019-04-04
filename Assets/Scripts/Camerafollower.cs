using UnityEngine;
using System.Collections;

public class Camerafollower : MonoBehaviour
{
    // The Target
    public Transform target;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(target.position.x,
                                         transform.position.y,
                                         transform.position.z);
    }
}