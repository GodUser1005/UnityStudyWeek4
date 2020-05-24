﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class Mover : MonoBehaviour
{

    public Vector3 move = new Vector3(-5,5,-5);
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Move();
        }
    }

    void Move()
    {
        transform.Translate(move*Time.deltaTime);
    }
}
