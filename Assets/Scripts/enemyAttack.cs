using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAttack : MonoBehaviour
{
    // Start is called before the first frame update

    public bool canAttack;
    public int damage;
    public PlayerControl control;
    void Start()
    {
        canAttack = true;
        control = PlayerControl.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator _coRoutine() {
        if (canAttack) {
            canAttack = false;
            if (control != null) {
                control.lives -= damage;
                Debug.Log("ouch " + control.lives );
                yield return new WaitForSeconds(2);
                canAttack = true;
            }
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
