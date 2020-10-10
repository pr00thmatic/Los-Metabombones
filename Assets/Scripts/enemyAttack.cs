using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAttack : MonoBehaviour
{
    // Start is called before the first frame update

    public bool canAttack;
    public PlayerControl control;
    void Start()
    {
        canAttack = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator _coRoutine() {
        if (canAttack) {
            canAttack = false;
            control.lives--;
            Debug.Log("ouch " + control.lives );
            yield return new WaitForSeconds(2);
            canAttack = true;
        }
    }
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "PlayerCollider") {
            StartCoroutine(_coRoutine());
        }
    }
    void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "PlayerCollider") {
            StartCoroutine(_coRoutine());
        }
    }
}
