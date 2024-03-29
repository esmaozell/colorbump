﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightAndLeftMoveObjects : MonoBehaviour
{
    public float speed, distance;
    private float minX, maxX;

    public bool right, dontMove;
    private bool stop;

    private void Start()
    {
        maxX = transform.position.x + distance;
        minX = transform.position.x - distance;
    }

    private void Update()
    {
        if (!dontMove)
        {
            if (right)
            {
                transform.position += Vector3.right * speed * Time.deltaTime;
                if (transform.position.x >= maxX)
                    right = false;
            }
            else
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
                if (transform.position.x <= minX)
                    right = true;
            }
        }
    }

    /*private void OnCollisionEnter(Collision target)
    {
        if (target.gameObject.tag == "White" || target.gameObject.name == "Player") ;
        {
            // if (target.gameObject.GetComponent<Rigidbody>().velocity.magnitude > 1)
            // {
            stop = true;
            GetComponent<Rigidbody>().freezeRotation = false;
            // }
        }
    }*/
}
