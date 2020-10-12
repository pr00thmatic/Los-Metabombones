using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelRestarter : MonoBehaviour {
  void Start () {
    PlayerControl.Instance.onPlayerDeath += HandleDeath;
  }

  public void HandleDeath () { StartCoroutine(_HandleDeath()); }
  IEnumerator _HandleDeath () {
    yield return new WaitForSeconds(3);
    LevelMusic.firstTime = false;
    SceneManager.LoadScene(gameObject.scene.name);
  }
}
