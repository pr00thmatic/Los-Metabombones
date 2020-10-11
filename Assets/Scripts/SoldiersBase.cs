using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldiersBase : MonoBehaviour {
  public float speed;
  public Transform exit;

  void Update () {
    transform.Rotate(0, speed * Time.deltaTime, 0);
  }
}
