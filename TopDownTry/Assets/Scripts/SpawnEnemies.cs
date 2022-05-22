using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject theEnemy;
    private GameObject player;
    private int xPos;
    private int zPos;
    public int enemyCount;
    public float timeBetSpawn;
    public int maxEnemies;
    public int radiusNotToSpawn;
    void Start()
    {
        if (player == null)
            player = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        
        while(enemyCount < maxEnemies)
        {
            do
            {
                xPos = Random.Range(-23, 23);
                zPos = Random.Range(-23, 23);
            } while ((xPos < player.transform.position.x + radiusNotToSpawn) && (xPos > player.transform.position.x - radiusNotToSpawn) && (zPos < player.transform.position.z + radiusNotToSpawn) && (zPos > player.transform.position.z - radiusNotToSpawn) && player!=null);
            
            Instantiate(theEnemy, new Vector3(xPos, 0, zPos), Quaternion.identity);
            yield return new WaitForSeconds(timeBetSpawn);
            enemyCount += 1;
        }
    }
}
