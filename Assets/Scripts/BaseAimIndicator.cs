using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseAimIndicator : MonoBehaviour {
  public PlayerControl control;

  void Update () {
    transform.forward = control.ballThrowDirection;
  }
}
