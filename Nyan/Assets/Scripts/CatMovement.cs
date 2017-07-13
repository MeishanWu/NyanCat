using System.Collections;
using System;
using UnityEngine;

public class CatMovement : MonoBehaviour {
    private Rigidbody2D rb2d;
    //private bool jump = false;
    //private bool crouch = false;
    public float force;// = 300f;
    //private bool isGrounded;
    //private int jumpCounter;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        //isGrounded = true;
        //jumpCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        
        System.Random rand = new System.Random();
        double r = rand.NextDouble();
        r = rand.NextDouble();
        if (r > 0.9)
        {
            rb2d.AddForce(new Vector2(0f, force));
        }
    }
}
