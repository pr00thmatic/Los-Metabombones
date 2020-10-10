using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonController : MonoBehaviour
{
    public float movementSpeed = 8;
    public GameObject root;
    public Rigidbody ball;
    public GameObject objetive;
    public GameObject start;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        root.transform.position = Vector3.MoveTowards(root.transform.position, 
                                                    objetive.transform.position, 
                                                    movementSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name ==  "Player")
        {
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.name == "Objetive")
        {
            // root.SetActive(false);
            root.transform.position = start.transform.position;
        }
    }
}
