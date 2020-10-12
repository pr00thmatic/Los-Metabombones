using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesUI : MonoBehaviour {
  public List<Animator> lives;

  void Start () {
    for (int i=1; i<PlayerControl.Instance.lives; i++) {
      GameObject spawn = Instantiate(lives[0].gameObject);
      spawn.transform.parent = transform;
      spawn.transform.localPosition = Vector3.zero;
      spawn.transform.localScale = Vector3.one;
      lives.Add(spawn.GetComponent<Animator>());
    }
  }

  void Update () {
    for (int i=0; i<lives.Count; i++) {
      lives[i].SetBool("alive", i < PlayerControl.Instance.lives);
    }
  }
}
