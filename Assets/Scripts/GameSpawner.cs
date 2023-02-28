using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] theEnemy;



    [SerializeField] float enemyCount;

    private void Start()
    {
        StartCoroutine(EnemyDrop());
    }



 


    private IEnumerator EnemyDrop()
    {
        while (enemyCount < 10)
        {
            float enemyPicker = Random.Range(0, theEnemy.Length);
            float xPos = Random.Range(-30, 30);
            float zPos = Random.Range(-101, 120);
            
            for (int i = 0; i < theEnemy.Length; i++)
            {
                if (enemyPicker == i)
                {
                    Instantiate(theEnemy[i], new Vector3(xPos, 2, zPos), Quaternion.identity);
                    yield return null;
                    enemyCount += 1;
                }
                
                
            }

        }
    }



   private void PreventSpawnerOverlap(Vector3 spawnPos)
    {
        for (int i = 0; i < theEnemy.Length; i++)
        {
            Vector3 centerPoint = theEnemy[i].bounds.center;
            float width = theEnemy[i].bounds.extents.x;
            floaty
        }
    }
}
