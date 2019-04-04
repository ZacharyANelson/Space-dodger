using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour
{
 
    public float speed = 2f;


    public float force = 300f;

    // Use this for initialization
    void Start()
    {

        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
        if (Input.GetKeyDown(KeyCode.D))
            speed = 10f;
        else
            speed = 2f;
    }
}