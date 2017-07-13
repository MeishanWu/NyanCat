using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FlyingStar : MonoBehaviour {

    private Rigidbody2D rb2d;

    // Use this for initialization
    void Start()
    {
        System.Random rand = new System.Random();
        float y = (float)(rand.NextDouble()*6 - 3);
        transform.position = new Vector3(9f, y, 0f);
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(-3f, 0f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
