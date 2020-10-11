using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFightStart : MonoBehaviour {
  public event System.Action onStart;

  void OnEnable () {
    onStart?.Invoke();
  }
}
