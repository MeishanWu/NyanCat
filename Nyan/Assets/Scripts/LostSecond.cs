using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LostSecond : MonoBehaviour {

    public float forceSecond;
    private Rigidbody2D rb2d;
    public int counterSecond;
    private GameObject player;
    // Use this for initialization
    void Start () {
        
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(new Vector2(0f, forceSecond));
        player = GameObject.Find("cat");
        transform.position = player.transform.position;


    }
	
	// Update is called once per frame
	void Update () {
        counterSecond--;
        if (counterSecond < 0)
        {
            Destroy(gameObject);
        }
	}
}
