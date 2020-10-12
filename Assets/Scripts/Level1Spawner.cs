using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject NormalEnemy;
	public GameObject HLPlus;
	public GameObject HLMinus;
	public GameObject HealOrDamage;


    public int totalEnemy = 1;
	private int numEnemy = 0;
	private int spawnedEnemy = 0;

    public bool spawn = true;
    public bool waveSpawn = true;
    public float waveTimer = 4.0f;
    private float timeTillWave = 0.0f;
	public int totalWaves = 100000;
	private int numWaves = 0;

    public PlayerControl control;
    void Start()
    {
        control = PlayerControl.Instance;
    }


    // Update is called once per frame
    void Update()
    {
        if (spawn) {
            if(numWaves <= totalWaves)
				{
					timeTillWave += Time.deltaTime;
					if (waveSpawn)
					{
						spawnEnemy();
					}
					if (timeTillWave >= waveTimer)
					{
						waveSpawn = true;
						timeTillWave = 0.0f;
						numWaves++;
						numEnemy = 0;
					}
					if(numEnemy >= totalEnemy)
					{
						waveSpawn = false;
					}
				}
				else
				{
					spawn = false;
				}
        }
    }

    private void spawnEnemy()
	{
		int rand = Random.Range(1, 1000);
		rand = rand % 4;
		GameObject Enemy ;
		float distance = Vector3.Distance(control.gameObject.transform.position, gameObject.transform.position);
		Debug.Log(distance);
		if (distance < 100) {
			if (rand == 0) {
				Enemy = (GameObject) Instantiate(NormalEnemy, gameObject.transform.position, Quaternion.identity);
			}
			if (rand == 1) {
				Enemy = (GameObject) Instantiate(NormalEnemy, gameObject.transform.position, Quaternion.identity);
			}
			if (rand == 2) {
				Enemy = (GameObject) Instantiate(NormalEnemy, gameObject.transform.position, Quaternion.identity);
			}
			if (rand == 3) {
				Enemy = (GameObject) Instantiate(NormalEnemy, gameObject.transform.position, Quaternion.identity);
			}
		}
		
 		// Increase the total number of enemies spawned and the number of spawned enemies
		numEnemy++;
		spawnedEnemy++;
	}

}
