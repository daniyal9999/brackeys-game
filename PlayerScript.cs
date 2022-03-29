using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rb;
    public int speed = 10;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        transform.position += new Vector3(x,0,0)*Time.deltaTime * speed;
        rb.AddForce(new Vector3(0,0,10));
    }
    // void OnCollisionEnter(Collision collision)
    // {
    //     if(collision.GameObject.tag == "obstacle")
    //     {
    //     Destroy(collision.gameObject);
    //     }
    // }
}
