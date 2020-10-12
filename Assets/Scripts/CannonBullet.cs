using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBullet : MonoBehaviour {
  public float speed;
  public Transform model;
  public Collider[] rocketInvulnerable;

  void Update () {
    transform.Translate(0, 0, speed * Time.deltaTime);
    // Vector3 r = model.transform.rotation.eulerAngles;
    // r.z = Camera.main.transform.rotation.x;
    // model.transform.rotation = Quaternion.Euler(r);
  }

  void OnTriggerEnter (Collider c) {
    if (!c.GetComponent<CollideWithBullet>()) return;
    Destroy(gameObject);
    PlayerControl.Instance.lives--;
  }
}
