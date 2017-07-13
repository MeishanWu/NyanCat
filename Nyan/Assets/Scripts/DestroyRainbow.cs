using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyRainbow : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "destroyer")
        {
            Destroy(gameObject);
        }
    }
}
