using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn2 : MonoBehaviour {
  public float timeToSpawn = 3;
  public float timeWithoutSpawning = 0;
  public GameObject enemy;

  void Start () {
    StartCoroutine(_Spawn());
  }

  IEnumerator _Spawn () {
    while (true) {
      yield return new WaitForSeconds(timeToSpawn);
      int amountOfEnemies = Random.Range(3, 5);
      while (amountOfEnemies > 0) {
        amountOfEnemies--;
        Instantiate(enemy); // ...
        yield return new WaitForSeconds(0.5f);
      }
    }
  }
}
