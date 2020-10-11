using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallConstraint : NonPersistentSingleton<BallConstraint> {
  public float maxDistance = 4;
  [HideInInspector]
  public Transform player;
  public Rigidbody body;
  public SpriteRenderer[] letalIndicator;
  public SphereCollider collider;

  void Start () {
    player = PlayerControl.Instance.transform;
  }

  void FixedUpdate () {
    Vector3 d = transform.position - player.position;
    if (d.magnitude > maxDistance * 0.8f) {
      body.velocity *= 0.8f;
    }
    d = Vector3.ClampMagnitude(d, maxDistance);
    transform.position = player.position + d;
    foreach (SpriteRenderer s in letalIndicator) {
      s.color = collider.enabled? new Color(1, 0.3f, 0.3f, 1): Color.white;
    }
  }
}
