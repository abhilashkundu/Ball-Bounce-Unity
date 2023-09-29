using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    public GameObject[] powerUps;
    private GameObject[] bricks;

    private void Start()
    {
        bricks = GameObject.FindGameObjectsWithTag("enemy");
        int numberOfBricks = bricks.Length;
        int powerUpsToSpawnInGame = Random.Range(3, numberOfBricks/3 <= 3 ? 4 : numberOfBricks/3) ;
        for(int i = 0; i < powerUpsToSpawnInGame; i++)
        {
            Instantiate(powerUps[Random.Range(0,powerUps.Length-1)], bricks[Random.Range(0, numberOfBricks - 1)].GetComponent<Transform>().position, Quaternion.identity);
        }
    }
}
