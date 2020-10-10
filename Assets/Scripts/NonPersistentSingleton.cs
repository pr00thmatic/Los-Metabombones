using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NonPersistentSingleton<T> : MonoBehaviour where T : MonoBehaviour {
  static T _instance;

  public static T Instance {
    get {
      if (!_instance) {
        _instance = GameObject.FindObjectOfType<T>();
      }
      if (!_instance) {
        _instance = new GameObject("LevelManager").AddComponent<T>();
      }

      return _instance;
    }
  }

  protected virtual void Awake () {
    if (Instance != this) {
      Destroy(gameObject);
    }
  }
}
