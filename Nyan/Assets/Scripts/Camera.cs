using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    private GameObject player;
    private Vector3 offset;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("player");
        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 playerPos = player.transform.position;
        transform.position = offset + playerPos;
	}
}
