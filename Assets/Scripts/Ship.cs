using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Ship : MonoBehaviour
{
 
    public float speed = 2f;

    public float force = 300f;

    public float speedup = 100f;

    public GameObject ship;

    public GameObject completelevel;

    public Collider2D groundcollider;

    

    


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
            GetComponent<Rigidbody2D>().AddForce(Vector2.right * speedup);

        if (GetComponent<Rigidbody2D>().IsTouching(groundcollider))
        {
            SceneManager.LoadScene("SampleScene");
        }

        if (GetComponent<Rigidbody2D>().position.x >= 47f)
        {
            completelevel.SetActive(true);
        }

        
        
     

        

       
    }
}