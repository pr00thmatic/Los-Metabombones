using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollow : MonoBehaviour {
  public float smoothTime = 0.25f;
  public Transform target;
  public Vector3 speed;

  void Update () {
    transform.position = Vector3.SmoothDamp(transform.position, target.position, ref speed, smoothTime);
  }
}
