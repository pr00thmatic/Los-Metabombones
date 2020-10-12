using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyController : MonoBehaviour
{
  // private Transform player;
  public float minDistance;
  private PlayerControl player;
  public Collider c;
  // Start is called before the first frame update
  void Start()
  {
    player = PlayerControl.Instance;
  }

  // Update is called once per frame
  void Update()
  {
    if (player != null && Vector3.Distance(player.transform.position, transform.position) < minDistance)
    {
      this.c.enabled = false;
      transform.Find("Healthy").gameObject.SetActive(false);
      transform.Find("Sick").gameObject.SetActive(true);
    }
  }

  private void OnTriggerEnter(Collider other)
  {
    
    if(other.gameObject.tag == "Virus")
    {
      player.lives--;
      this.c.enabled = false;
      transform.Find("Healthy").gameObject.SetActive(false);
      Destroy(transform.Find("Healthy").gameObject);
      transform.Find("Sick").gameObject.SetActive(true);
      other.gameObject.SetActive(false);
    }
  }
}
