using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleCollider : MonoBehaviour
{
    // Start is called before the first frame update
    Collider m_Collider;
     public PlayerControl control;
    void Start()
    {
        m_Collider = GetComponent<Collider>();
        control.onThrowBallRequested += toggle;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator _coRoutine() {
        m_Collider.enabled = true;
        Debug.Log(m_Collider.enabled);
        yield return new WaitForSeconds(1);
        m_Collider.enabled = false;
        Debug.Log(m_Collider.enabled);
    }
    void toggle() {
        StartCoroutine(_coRoutine());
    }
}
