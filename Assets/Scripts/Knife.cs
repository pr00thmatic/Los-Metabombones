using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour {
  public Animator animator;
  public BossSoldier soldier;

  void Update () {
    transform.forward = PlayerControl.Instance.transform.position - transform.position;
  }

  public void Attack () { gameObject.SetActive(true); StartCoroutine(_Attack()); }
  IEnumerator _Attack () {
    yield return null;
    yield return null;
    soldier.enabled = false;
    animator.SetTrigger("Attack");
    yield return new WaitForSeconds(0.6f);
    soldier.enabled = true;
  }
}
