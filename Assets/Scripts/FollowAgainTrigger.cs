using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowAgainTrigger : MonoBehaviour {
  public CameraFollow follower;

  void OnTriggerStay (Collider c) {
    if (c.GetComponent<Player>()) {
      follower.follow = false;
      follower.speed = Vector3.zero;
    }
  }
}
