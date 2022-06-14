using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner3 : MonoBehaviour
{
    public GameObject theEnemy;
    private GameObject player;
    private PlayerController playerScript;
    private int xPos;
    private int zPos;
    private int xTry1;
    private int xTry2;
    private int xTry3;
    private int xTry4;
    private int xTry5;
    private int xTry6;
    private int xTry7;
    private int zTry1;
    private int zTry2;
    private int zTry3;
    private int zTry4;
    private int zTry5;
    private int zTry6;
    private int zTry7;
    private int sp;
    
    public int enemyCount;
    public float timeBetSpawn;
    public int ScoreMaxEnemies;
    public int radiusNotToSpawn;

    public static EnemySpawner3 Instance;

    void Start()
    {
        enemyCount = 0;
        if (player == null)
            player = GameObject.FindGameObjectWithTag("Player");
        if (playerScript == null)
            playerScript=player.GetComponent<PlayerController>();
        EnemyDrop();
    }
    void Update()
    {
        Instance = GetComponent<EnemySpawner3>();
        EnemyDrop();
    }

    void EnemyDrop()
    {

        
        while(playerScript.points < ScoreMaxEnemies && enemyCount <5)
        {


            do
            {
                xTry1= Random.Range(-23, -20);
                zTry1 = Random.Range(-13, -11);

                xTry2= Random.Range(-11, -8);
                zTry2= Random.Range(-22, -20);

                xTry3 = Random.Range(16, 19);
                zTry3 = Random.Range(-22, -18);

                xTry4 = Random.Range(14, 15);
                zTry4 = Random.Range(16, 18);

                xTry5 = Random.Range(21, 22);
                zTry5 = Random.Range(10, 11);

                xTry6 = Random.Range(-23, -21);
                zTry6 = Random.Range(18, 20);

                xTry7 = Random.Range(-22, -20);
                zTry7 = Random.Range(5, 7);

                sp = Random.Range(1,8);
                if(sp == 1)
                {
                    xPos = xTry1;
                    zPos = zTry1;
                }
                else if(sp == 2)
                {
                    xPos = xTry2;
                    zPos = zTry2;
                }
                else if(sp == 3)
                {
                    xPos = xTry3;
                    zPos = zTry3;
                }
                else if(sp == 4)
                {
                    xPos = xTry4;
                    zPos = zTry4;
                }
                else if(sp == 5)
                {
                    xPos = xTry5;
                    zPos = zTry5;
                }
                else if(sp == 6)
                {
                    xPos = xTry6;
                    zPos = zTry6;
                }
                else
                {
                    xPos = xTry7;
                    zPos = zTry7;
                }

            } while ((xPos < player.transform.position.x + radiusNotToSpawn) && (xPos > player.transform.position.x - radiusNotToSpawn) && (zPos < player.transform.position.z + radiusNotToSpawn) && (zPos > player.transform.position.z - radiusNotToSpawn) && player!=null);
            
            Instantiate(theEnemy, new Vector3(xPos, 0, zPos), Quaternion.identity);
            
            enemyCount += 1;
        }
    }
}
