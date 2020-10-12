using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWillBeDie : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Ball") {
            Destroy(this.gameObject);
      if(transform.parent)
      {
        Destroy(transform.parent.gameObject);
      }
            

      Debug.Log("LOL u die lol lol u die");
        }
    }
}
