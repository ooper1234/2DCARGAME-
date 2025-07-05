using System.Collections;
using UnityEngine;

public class EnemyTypeShit : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject enemyPrefab;
    public float secondToSpawn = 3;
    public int spawnDirection = 1;
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
            GameObject enemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            Enemy controller = enemy.GetComponent<Enemy>();
            float rotationDegree = -90f;
            if (spawnDirection == 1) {
                rotationDegree = 90f;
            }
            if (controller)
            {
                controller.direction = spawnDirection;
                controller.transform.rotation = Quaternion.Euler(
                    0, 0, rotationDegree
                );
            }
        }

    }
}
