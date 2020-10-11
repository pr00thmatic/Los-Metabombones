using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLevel1 : MonoBehaviour {
  public CannonInvulnerability lastCannon;
  public GameObject boss;

  void OnEnable () {
    lastCannon.onDestroy += HandleNextLevel;
  }

  public void HandleNextLevel () {
    Destroy(boss);
    LevelMusic.Instance.FadeSound();
  }
}
