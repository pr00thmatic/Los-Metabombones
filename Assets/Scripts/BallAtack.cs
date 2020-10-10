using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallAtack : MonoBehaviour
{
    public PlayerControl control;
    public Rigidbody rb;
    public float force = 777;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        control.onThrowBallRequested += throwBall;
    }

    // Update is called once per frame
    void Update()
    {
        //something with onThrowBallRequested
    }
    void throwBall() 
    {   
        rb.AddForce(control.ballThrowDirection.x * force, control.ballThrowDirection.y * force, control.ballThrowDirection.z * force, ForceMode.VelocityChange );
        Debug.Log("FORCE " + this.force);

    }
}
