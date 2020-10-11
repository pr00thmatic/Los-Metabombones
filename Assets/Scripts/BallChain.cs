using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallChain : MonoBehaviour {
  public LineRenderer line;
  public Transform origin;
  public Transform ball;

  void FixedUpdate () {
    line.SetPosition(0, origin.transform.position);
    line.SetPosition(1, ball.transform.position);
  }
}
