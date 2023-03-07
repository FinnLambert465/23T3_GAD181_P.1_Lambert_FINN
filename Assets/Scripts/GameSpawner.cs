using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] theEnemy;
    [SerializeField] private List<GameObject> existingEnemies = new List<GameObject>();


    [SerializeField] float enemyCount;

    private void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    private IEnumerator EnemyDrop()
    {
       
        while (enemyCount < 15)
        {
            int enemyPicker = Random.Range(0, theEnemy.Length);
            float xPos = Random.Range(-30, 30);
            float zPos = Random.Range(-101, 120);

            Instantiate(theEnemy[enemyPicker], new Vector3(xPos, 2, zPos), Quaternion.identity);
            enemyCount += 1;

            //for (int i = 0; i < theEnemy.Length; i++)
            //{
            //    if (enemyPicker == i)
            //    {
            //        Instantiate(theEnemy[i], new Vector3(xPos, 2, zPos), Quaternion.identity);
            //        yield return null;

            //        enemyCount += 1;
            //    }


            //}

            //-------------------------------------------------------------------------------------------------------
            foreach (GameObject enemy in existingEnemies)
            {
                
                // 1 pick a random position
                // 2 if that position is near to any existing enemies, repeat from 1
                do
                {
                    xPos = Random.Range(-30, 30);
                    zPos = Random.Range(-101, 120);
                    
                } while (Vector3.Distance(new Vector3(xPos, 2, zPos), enemy.transform.position) < 3000);

               

                // 3 spawn an enemy at that position
                Instantiate(theEnemy[enemyPicker], new Vector3(xPos, 2, zPos), Quaternion.identity);
                enemyCount += 1;
            }
            yield return null;
        }
    }
}
