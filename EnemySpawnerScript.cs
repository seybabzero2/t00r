using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    [SerializeField]
    private GameObject swarmerPrefab;
    [SerializeField]
    private GameObject bigSwarmerPrefab;

    [SerializeField]
    private float swarmerInterval = 3.5f;
    [SerializeField]
    private float bigSwarmerInterval = 10f;

    [SerializeField]
    private int enemyCounter = 0;

    public int enemyAmount = 0;

    public float field = 8f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(swarmerInterval, swarmerPrefab));
        StartCoroutine(spawnEnemy(bigSwarmerInterval, bigSwarmerPrefab));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        if (enemyCounter <= enemyAmount) { 
            yield return new WaitForSeconds(interval);
            GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-field, field), Random.Range(-field, field), 0), Quaternion.identity);
            enemyCounter = enemyCounter + 1;
            StartCoroutine(spawnEnemy(interval, enemy));
        }
    }
}