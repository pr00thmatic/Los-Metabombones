using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateOnPlayerTouch : MonoBehaviour {
  public GameObject target;
  public bool active = true;

  void OnTriggerEnter (Collider c) {
    if (c.GetComponentInParent<PlayerControl>()) {
      target.SetActive(active);
      this.enabled = false;
    }
  }
}
