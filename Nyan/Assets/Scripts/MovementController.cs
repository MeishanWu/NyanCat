using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {

    private Rigidbody2D rb2d;
    //private bool jump = false;
    //private bool crouch = false;
    public float force;// = 300f;
    private bool isGrounded;
    private int jumpCounter;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        isGrounded = true;
        jumpCounter = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))// && jumpCounter <= 2)
        {
            rb2d.AddForce(new Vector2(0f, force));
            jumpCounter++;
        }
		/*if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector2 scale = new Vector2(1f, 0.5f);
            rb2d.transform.localScale = scale;
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            Vector2 scale = new Vector2(1f, 1f);
            rb2d.transform.localScale = scale;
        }*/
    }
}
