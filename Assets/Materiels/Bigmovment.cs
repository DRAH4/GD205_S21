﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bigmovment : MonoBehaviour
{
    public Vector3 fwd;
    public Vector3 bkwd;
    public Vector3 rht;
    public Vector3 lft;
    public Vector3 dwn;
    public Vector3 up;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("you pressed w :)");
            transform.position += fwd;
        }
        {
            if (Input.GetKeyDown(KeyCode.S))
                transform.position += bkwd;
        }
        {
            if (Input.GetKeyDown(KeyCode.D))
                transform.position += rht;
        }
        {
            if (Input.GetKeyDown(KeyCode.A))
                transform.position += lft;
        }
        {
            if (Input.GetKeyDown(KeyCode.Q))
                transform.position += dwn;
        }
        {
            if (Input.GetKeyDown(KeyCode.E))
                transform.position += up;
        }
    }
}
