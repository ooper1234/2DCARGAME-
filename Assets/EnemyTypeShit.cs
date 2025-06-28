using System.Collections;
using UnityEngine;

public class EnemyTypeShit : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject enemyPrefab;
    public float secondToSpawn = 3;
    void Start()
    {
        StartCoroutine(DelaySpawnKaren(secondToSpawn));
    }

    // Update is called once per frame
    IEnumerator DelaySpawnKaren(float sec)
    {
        while (true)
        {
            yield return new WaitForSeconds(sec);
            Debug.Log("Spawned Enemy");
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        }

    }
}
