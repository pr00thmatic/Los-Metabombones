using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public Boolean nearby = false;
    public GameObject root;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("asdasd! " + Time.time);
        if (other.gameObject.name == "Player")
        {
            nearby = true;
        }
    }
}
