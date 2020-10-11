using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BossSoldier : MonoBehaviour {
  public float speed;
  public bool spinning = false;
  public bool attacking = false;
  public bool leaving = false;
  public Vector2 timeRange = new Vector2(2, 4.5f);
  public float timeSpinning;
  public Transform target;
  public NavMeshAgent agent;
  public float programmedDeath = 7;

  void Update () {
    if (spinning) {
      timeSpinning -= Time.deltaTime;
      if (timeSpinning <= 0) {
        attacking = true;
        spinning = false;
        target = transform.parent;
        transform.parent = null;
      }
      return;
    }

    if (attacking) {
      transform.position = Vector3.MoveTowards(transform.position, target.position,
                                               speed * Time.deltaTime);
      if (transform.position == target.position) {
        agent.enabled = true;
        agent.SetDestination(target.GetComponent<SoldiersBase>().exit.position);
        leaving = true;
        attacking = false;
        Debug.Log(target.GetComponent<SoldiersBase>().exit);
      }
      return;
    }

    if (leaving) {
      programmedDeath -= Time.deltaTime;
      if (programmedDeath <= 0) Destroy(gameObject);
      return;
    }

    transform.position = Vector3.MoveTowards(transform.position, PlayerControl.Instance.transform.position,
                                             speed * Time.deltaTime);
  }

  void OnTriggerEnter (Collider c) {
    if (spinning) return;
    if (c.GetComponent<SoldiersBase>()) {
      transform.parent = c.transform;
      spinning = true;
      timeSpinning = Random.Range(timeRange.x, timeRange.y);
    }
  }
}
