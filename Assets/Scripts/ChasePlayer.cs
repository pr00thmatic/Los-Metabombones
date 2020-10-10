﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public float moveSpeed = 5f;
    private Rigidbody rb;
    private Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        Vector3 direction = player.position - transform.position;
        Quaternion angle =  Quaternion.LookRotation(direction, Vector3.up);
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;
    }
    private void FixedUpdate() {
        moveCharacter(movement);
    }
    void moveCharacter(Vector3 direction){
        Debug.Log(direction);
        if (Vector3.Distance(player.position, transform.position) > 1) {
           rb.MovePosition(transform.position + (direction * moveSpeed * Time.deltaTime));
        }
    }
}
