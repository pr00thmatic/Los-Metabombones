using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour {
  public float timeToShoot = 1;
  public float cooldown = 0;
  public GameObject rocketPrototype;
  public Transform bulletsFolder;
  public Transform spawningPoint;

  void Update () {
    cooldown -= Time.deltaTime;
    if (cooldown <= 0) {
      cooldown = timeToShoot;
      GameObject rocket = Instantiate(rocketPrototype, spawningPoint.transform.position,
                                      spawningPoint.transform.rotation);
      rocket.transform.parent = bulletsFolder;
    }
  }
}
