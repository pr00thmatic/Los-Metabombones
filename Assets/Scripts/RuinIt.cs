using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuinIt : MonoBehaviour {
  public GameObject smoke;
  public CannonInvulnerability cannon;

  void Start () {
    cannon.onDestroy += ActivateSmoke;
  }

  public void ActivateSmoke () {
    smoke.SetActive(true);
  }
}
