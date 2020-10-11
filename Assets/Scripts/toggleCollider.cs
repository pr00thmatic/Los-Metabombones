using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleCollider : MonoBehaviour
{
    // Start is called before the first frame update
    Collider m_Collider;
     public AudioClip audio;
     public PlayerControl control;
    void Start()
    {
        m_Collider = GetComponent<Collider>();
        control.onThrowBallRequested += toggle;
        GetComponent<AudioSource> ().playOnAwake = false;
         GetComponent<AudioSource> ().clip = audio;
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
        Debug.Log("collider " + m_Collider.enabled);
    }
    void toggle() {
        StopAllCoroutines();
        StartCoroutine(_coRoutine());
    }
    void OnTriggerEnter(Collider other) {
        Debug.Log("tag === " + other.gameObject.tag );
        if (other.gameObject.tag == "Enemy") {
            Debug.Log("ATTACKING BALLLLLLLLLLLLLLLLLLLLLLLL");
            GetComponent<AudioSource> ().PlayOneShot(audio, 1F);

        }
    }

}
