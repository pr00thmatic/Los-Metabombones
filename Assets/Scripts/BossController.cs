using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UIElements;

public class BossController : MonoBehaviour
{
  public GameObject Proyectil;
  public GameObject Ally1;
  public GameObject Ally2;
  public GameObject Ally3;
  public GameObject Ally4;
  public GameObject Ally5;
  private int phase = 1;
  private float phaseTime = 10f;
  private float currentTime = 0f;
  private float currentTimeSpawn = 0f;
  private float inter = 2f;
  private System.Random random = new System.Random();
  //private GameObject[] Allies;
  private List<GameObject> Attacks = new List<GameObject>();
  private List<int> Objetives = new List<int>();
  private List<GameObject> Allies = new List<GameObject>();
  private bool inmune;
  private bool start = false;
  public float proyectilSpeed = 5f;
  public Transform player;

  // Start is called before the first frame update
  void Start()
  {
    Allies.Add(Ally1);
    Allies.Add(Ally2);
    Allies.Add(Ally3);
    Allies.Add(Ally4);
    Allies.Add(Ally5);
    inmune = true;
    start = false;
    player = PlayerControl.Instance.transform;
  }

  // Update is called once per frame
  void Update()
  {
    Debug.Log(Vector3.Distance(player.position, transform.position));
    if (player != null && Vector3.Distance(player.position, transform.position) < 40)
    {
      start = true;
    }
    if (currentTimeSpawn > inter && start)
    {
      currentTimeSpawn = 0f;
      if (phase == 1)
      {
        spawnAttack();
      }
      else if (phase == 2)
      {
        proyectilSpeed = 7;
        spawnAttack();
      }
      else if (phase == 3)
      {
        spawnAttack();
        spawnAttack();
      } else if (phase == 4)
      {
        inmune = false;
        spawnAttack();
        spawnAttack();
        spawnAttack();
        proyectilSpeed = 10;
      }
      if (currentTime > phaseTime)
      {
        currentTime = 0;
        phase++;
      }
    }
    currentTimeSpawn += Time.deltaTime;
    currentTime += Time.deltaTime;
    move();
  }
  private void spawnAttack()
  {
    GameObject Atack = (GameObject) Instantiate(Proyectil, gameObject.transform.position, Quaternion.identity);
    int x = random.Next(0, 5);
    Objetives.Add(x);
    Attacks.Add(Atack);
    return;
  }
  private void move()
  {
    for(int i = 0; i < Attacks.Count; i++)
    {
      Attacks[i].transform.position = Vector3.MoveTowards(Attacks[i].transform.position, Allies[Objetives[i]].transform.position, proyectilSpeed * Time.deltaTime);
    }
  }
  private void OnTriggerEnter(Collider other)
  {
    if(!inmune && other.gameObject.tag == "Ball")
    {
      Destroy(this.gameObject);
      LevelMusic.Instance.FadeSound();
    }
  }
}
