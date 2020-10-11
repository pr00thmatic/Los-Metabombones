using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateOnPlayerTouch : MonoBehaviour {
  public GameObject target;

  void OnTriggerEnter (Collider c) {
    if (c.GetComponentInParent<PlayerControl>()) {
      target.SetActive(true);
      this.enabled = false;
    }
  }
}
