using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BossSoldier : MonoBehaviour {
  public float Speed { get => speedMultiplier * speed; }

  public float speedMultiplier = 1;
  public float speed;
  public bool attacked = false;
  public bool spinning = false;
  public bool attacking = false;
  public bool leaving = false;
  public Vector2 timeRange = new Vector2(2, 4.5f);
  public float timeSpinning;
  public Transform target;
  public NavMeshAgent agent;
  public float programmedDeath = 7;
  // public Vector3 attackTarget;

  void Update () {
    if (spinning) {
      timeSpinning -= Time.deltaTime;
      if (timeSpinning <= 0) {
        speedMultiplier = 0.8f;
        attacking = true;
        spinning = false;
        target = transform.parent;
        transform.parent = null;
      }
      return;
    }

    if (attacking) {
      if (!target) Destroy(gameObject);
      transform.position = Vector3.MoveTowards(transform.position, target.position,
                                               Speed * Time.deltaTime);
      if (transform.position == target.position) {
        speedMultiplier = 1.5f;
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
                                             Speed * Time.deltaTime);
  }

  void OnTriggerEnter (Collider c) {
    if (spinning) return;
    if (c.GetComponent<SoldiersBase>()) {
      transform.parent = c.transform;
      spinning = true;
      timeSpinning = Random.Range(timeRange.x, timeRange.y);
    } else if (!attacked && c.GetComponentInParent<PlayerControl>()) {
      PlayerControl.Instance.lives--;
      attacked = true;
      spinning = attacking = false;
      leaving = true;
    }
  }
}
