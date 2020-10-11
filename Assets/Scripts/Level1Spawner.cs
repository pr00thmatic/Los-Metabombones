using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject SoldierEnemy;


    public int totalEnemy = 10;
	private int numEnemy = 0;
	private int spawnedEnemy = 0;

    public bool spawn = true;
    public bool waveSpawn = true;
    public float waveTimer = 3.0f;
    private float timeTillWave = 0.0f;
	public int totalWaves = 5;
	private int numWaves = 0;

    void Start()
    {
        
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
		GameObject Enemy = (GameObject) Instantiate(SoldierEnemy, gameObject.transform.position, Quaternion.identity);
		// Increase the total number of enemies spawned and the number of spawned enemies
		numEnemy++;
		spawnedEnemy++;
	}

}
