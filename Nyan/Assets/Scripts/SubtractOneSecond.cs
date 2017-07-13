using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubtractOneSecond : MonoBehaviour {
    public GameObject ones;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "star")
        {
            Destroy(coll.gameObject);
            ones = (GameObject)Resources.Load("ones", typeof(GameObject));
            Instantiate(ones);
        }
        
    }
}
