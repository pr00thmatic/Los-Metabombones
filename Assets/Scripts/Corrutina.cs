using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corrutina : MonoBehaviour {
  void Start () {
    StartCoroutine(_Corrutina());
  }
  IEnumerator _Corrutina () {
    Debug.Log("la corrutina comenzó!");
    yield return new WaitForSeconds(2);
    Debug.Log("la corrutina terminó!");
  }
}
