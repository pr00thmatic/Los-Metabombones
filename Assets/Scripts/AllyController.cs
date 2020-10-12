using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyController : MonoBehaviour
{
  private Transform player;
  public float minDistance;
  // Start is called before the first frame update
  void Start()
  {
    player = PlayerControl.Instance.transform;
  }

  // Update is called once per frame
  void Update()
  {
    if (player != null && Vector3.Distance(player.position, transform.position) < minDistance)
    {
      transform.Find("Healthy").gameObject.SetActive(false);
      transform.Find("Sick").gameObject.SetActive(true);
    }
  }

  private void OnTriggerEnter(Collider other)
  {
    
    if(other.gameObject.tag == "Virus")
    {
      transform.Find("Healthy").gameObject.SetActive(false);
      Destroy(transform.Find("Healthy").gameObject);
      transform.Find("Sick").gameObject.SetActive(true);
      other.gameObject.SetActive(false);
    }
  }
}
