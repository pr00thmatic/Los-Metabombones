using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossElement : MonoBehaviour {
  public BossFightStart boss;
  public MonoBehaviour[] things;

  void Start () {
    boss.onStart += Activate;
  }

  public void Activate () {
    foreach (MonoBehaviour thing in things) {
      thing.enabled = true;
    }
  }
}
