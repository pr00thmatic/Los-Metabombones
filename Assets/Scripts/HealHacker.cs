using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealHacker : MonoBehaviour
{
    // Start is called before the first frame update

     public HackerBossLife control;
     public GameObject parent;
     
    void Start()
    {
        control = HackerBossLife.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball") {
            control.anonymusLife = control.anonymusLife + 1;
            Debug.Log(control.anonymusLife);
            Destroy(parent);
        }
    }
}
