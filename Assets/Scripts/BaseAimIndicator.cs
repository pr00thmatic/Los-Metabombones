using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseAimIndicator : MonoBehaviour {
  public PlayerControl control;

  void Update () {
    transform.forward = Vector3.Scale(new Vector3(1,0,1), control.ballThrowDirection);
  }
}
