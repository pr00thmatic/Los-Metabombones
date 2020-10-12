using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBullet : MonoBehaviour {
  public float speed;
  public Transform model;
  public Collider[] rocketInvulnerable;
  public bool attacked = false;

  void Update () {
    transform.Translate(0, 0, speed * Time.deltaTime);
    // Vector3 r = model.transform.rotation.eulerAngles;
    // r.z = Camera.main.transform.rotation.x;
    // model.transform.rotation = Quaternion.Euler(r);
  }

  void OnTriggerEnter (Collider c) {
    if (attacked || !c.GetComponent<CollideWithBullet>()) return;
    Destroy(gameObject);
    if (c.GetComponentInParent<PlayerControl>()) {
      PlayerControl.Instance.lives--;
    }
    attacked = true;
  }
}
