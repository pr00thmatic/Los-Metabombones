using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aggressiveness : MonoBehaviour {
  public float speed = 8;
  public GameObject target;
  public GameObject root;
  public GameObject attackState;

  void Update () {
    root.transform.position = Vector3.MoveTowards(root.transform.position, target.transform.position,
                                                  speed * Time.deltaTime);
  }

  void OnTriggerEnter (Collider c) {
    // verificar que c es el jugador
    gameObject.SetActive(false);
    attackState.SetActive(true);
  }
}
