using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour {
  void OnTriggerEnter (Collider c) {
    Rigidbody body = c.GetComponentInParent<Rigidbody>();
    if (body) {
      body.AddForce((c.transform.position - transform.position).normalized *
                    (body.velocity.magnitude + 15), ForceMode.VelocityChange);
    }
  }
}
