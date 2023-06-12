using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce=200f;
    bool jump = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent< Rigidbody>();
   
       
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
            jumpM();
        }
    }
    void jumpM()
    {

        rb.AddForce(0, jumpForce, 0);
        jump = false;
    }
}
