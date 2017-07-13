using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainbowTrace : MonoBehaviour {
    public GameObject rainbow;

    void Start()
    {
        InvokeRepeating("CreateRainbow", 0f, 0.08f);
    }

    void CreateRainbow()
    {
        rainbow = (GameObject)Resources.Load("rainbow", typeof(GameObject));
        Instantiate(rainbow);
    }
}
