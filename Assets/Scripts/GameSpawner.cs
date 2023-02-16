using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] theEnemy;

    [SerializeField] float xPos;
    [SerializeField] float zPos;

    [SerializeField] float enemyCount;

    private void Start()
    {
        StartCoroutine(EnemyDrop());
    }


    private IEnumerator EnemyDrop()
    {
        while (enemyCount < 20)
        {
            xPos = Random.Range(-30, 30);
            zPos = Random.Range(-101, 120);
            for (int i = 0; i < theEnemy.Length; i++)
            {
                Instantiate(theEnemy[i], new Vector3(xPos, 1, zPos), Quaternion.identity);
                yield return null;
            }

        }
    }
}
