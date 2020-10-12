using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    
    public float moveSpeed = 5f;
    private Rigidbody rb;
    private Vector3 movement;
    private float lastX;

    public int minimumDistance = 15;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        player = PlayerControl.Instance.transform;
    }

    // Update is called once per frame
    void Update() {
            Vector3 direction = player.position - transform.position;
            Quaternion angle =  Quaternion.LookRotation(direction, Vector3.up);
            // rb.rotation = angle;
            direction.Normalize();
            movement = direction;
        
    }
    private void FixedUpdate() {
         if (player != null && Vector3.Distance(player.position, transform.position) < minimumDistance) {
            moveCharacter(movement);
        }
    }
    void moveCharacter(Vector3 direction){
     //   Debug.Log(direction);
     Debug.Log(Vector3.Distance(player.position, transform.position));
        if (Vector3.Distance(player.position, transform.position) > 2.5) {
            direction.y = 0;
           rb.MovePosition(transform.position + (direction * moveSpeed * Time.deltaTime));
        }/*
        if(transform.position.x > lastX)
        {
          transform.Find("SpriteRight").gameObject.SetActive(false);
          transform.Find("SpriteLeft").gameObject.SetActive(true);
        } else
        {
          transform.Find("SpriteRight").gameObject.SetActive(true);
          transform.Find("SpriteLeft").gameObject.SetActive(false);
        }
        lastX = transform.position.x;*/
    }
}
