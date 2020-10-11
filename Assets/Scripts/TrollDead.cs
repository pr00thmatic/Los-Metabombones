using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TrollDead : MonoBehaviour
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
            Debug.Log("LOL u die lol lol u die");
            SceneManager.LoadScene (sceneName:"Lua");
        }
    }
}
