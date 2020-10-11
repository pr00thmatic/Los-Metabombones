using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealBillboard : MonoBehaviour {
  void Update () {
    transform.forward = Camera.main.transform.position - transform.position;
  }
}
