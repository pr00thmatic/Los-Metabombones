using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
  public float timeToIdle = 0.5f;
  public float smoothTime = 0.5f;
  public Transform root;
  public Transform target;
  public Vector3 speed;
  public bool follow = false;

  void FixedUpdate () {
    if (!follow) return;

    root.transform.position = Vector3.SmoothDamp(root.transform.position, target.position, ref speed,
                                                 smoothTime);
  }

  void OnTriggerExit (Collider c) {
    if (c.GetComponent<Player>()) {
      follow = true;
    }
  }
}
