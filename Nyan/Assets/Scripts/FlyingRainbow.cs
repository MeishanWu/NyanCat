using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingRainbow : MonoBehaviour {

    private Rigidbody2D rb2d;
    private GameObject player;
    // Use this for initialization
    void Start()
    {

        rb2d = GetComponent<Rigidbody2D>();
        player = GameObject.Find("cat");
        transform.position = player.transform.position;
        rb2d.velocity = new Vector2(-3f, 0f);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
