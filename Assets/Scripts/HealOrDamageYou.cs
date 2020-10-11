using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealOrDamageYou : MonoBehaviour
{
    // Start is called before the first frame update
    
    
    public PlayerControl control;
    public GameObject parent;
    void Start()
    {
        control = PlayerControl.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

      void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball") {
            control.lives = control.lives - 1;
            Destroy(parent);
        }
        if (other.gameObject.tag == "PlayerCollider") {
            control.lives = control.lives + 1;
            Destroy(parent);
        }
    }
}
