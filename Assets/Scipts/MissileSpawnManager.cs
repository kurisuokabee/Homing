using System.Collections;
using UnityEngine;


public class MissileSpawnManager : MonoBehaviour
{
    [SerializeField] Transform[] spawnPoints;
    [SerializeField] GameObject missilePrefab;
    [SerializeField] Transform player;
     
    [SerializeField] int missileCount = 1;

    void Start()
    {
        StartCoroutine(SpawnMissile());
        StartCoroutine(IncreaseMissileCount());
    }

    IEnumerator SpawnMissile()
    {
        while(true)
        {    
            yield return new WaitForSeconds(3f);

            for(int i = 0; i < missileCount; i++)
            {
                GameObject missileGO = Instantiate(missilePrefab, spawnPoints[Random.Range(0, spawnPoints.Length)].position, Quaternion.identity);

                HomingMissileDetection detection = missileGO.GetComponent<HomingMissileDetection>();
                HomingMissileMovement movement = missileGO.GetComponent<HomingMissileMovement>();

                detection.target = player;
                movement.target = player;
            }
        }
    }

    IEnumerator IncreaseMissileCount()
    {   
        while(true)
        {
            yield return new WaitForSeconds(10f);

            if(player.gameObject.activeInHierarchy) missileCount++;
        }
    }
}
