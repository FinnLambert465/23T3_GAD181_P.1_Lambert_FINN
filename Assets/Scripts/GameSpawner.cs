using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] theEnemy;
    [SerializeField]
    Collider[] theCollider;
    [SerializeField] float radius = 0f;


    [SerializeField] float enemyCount;

    private void Start()
    {
        StartCoroutine(EnemyDrop());
        theCollider = Physics.OverlapSphere (transform.position, radius);
    }

    private IEnumerator EnemyDrop()
    {
        while (enemyCount < 15)
        {
            float enemyPicker = Random.Range(0, theEnemy.Length);
            float xPos = Random.Range(-30, 30);
            float zPos = Random.Range(-101, 120);
            
            for (int i = 0; i < theEnemy.Length; i++)
            {
                if (enemyPicker == i)
                {
                    //bool canSpawnHere;

                    //canSpawnHere = PreventSpawnerOverlap(spawnPos);

                    Instantiate(theEnemy[i], new Vector3(xPos, 2, zPos), Quaternion.identity);
                    yield return null;

                    enemyCount += 1;
                }
                
                
            }

        }
    }



   //private void PreventSpawnerOverlap(Vector3 spawnPos)
   // {
   //     for (int i = 0; i < theEnemy.Length; i++)
   //     {
   //         theCollider = Physics.OverlapSphere(transform.position, radius);
   //         for (int i = 0; i < theCollider.Length; i++)
   //         {
   //             Vector3 centerPoint = theCollider.bounds.center;
   //             float width = theCollider.bounds.extents.x;
   //             float lenghth = theCollider.bounds.extents.x;
   //             float hight = 5;

   //             float leftExtent = centerPoint.x - width;
   //             float rightExtent = centerPoint.x + width;
   //             float lowerExtent = centerPoint.z - width;
   //             float upperExtent = centerPoint.z + width;

   //             if (spawnPos.x >= leftExtent && spawnPos.x <= rightExtent)
   //             {
   //                 if (spawnPos.y >= lowerExtent && spawnPos.z <= upperExtent)
   //                 {
   //                     return false;
   //                 }
   //                 return false;
   //             }
   //         }
   //     }
   // }
}
