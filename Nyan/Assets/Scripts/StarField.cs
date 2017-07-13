using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarField : MonoBehaviour {

    public GameObject star;

    void Start()
    {
        InvokeRepeating("CreateStars", 0.3f, 0.3f);
    }

    void CreateStars()
    {
        star = (GameObject)Resources.Load("star", typeof(GameObject));
        Instantiate(star);
    }
}
