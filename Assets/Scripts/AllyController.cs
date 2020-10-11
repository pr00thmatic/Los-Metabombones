using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyController : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
        
  }

  // Update is called once per frame
  void Update()
  {
        
  }

  private void OnTriggerEnter(Collider other)
  {
    
    if(other.gameObject.tag == "Virus")
    {
      transform.Find("Healthy").gameObject.SetActive(false);
      transform.Find("Sick").gameObject.SetActive(true);
      other.gameObject.SetActive(false);
    }
  }
}
