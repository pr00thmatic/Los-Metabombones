using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusController : MonoBehaviour
{
  public Rigidbody body;
  public PlayerControl player;
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
    if (other.gameObject.tag == "Ball")
    {
      this.gameObject.SetActive(false);
      body.detectCollisions = false;
    }
    if(other.gameObject.tag == "Player")
    {
      this.gameObject.SetActive(false);
      player.lives--;
    }
  }
}
