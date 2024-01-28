using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    private Spawner[] _spawners;

    private IEnumerator CreateEnemyRandomSpawner(Spawner[] spawners)
    {
        bool isWorkinkg = true;

        while (isWorkinkg)
        {
            int keyRandomSpawner = Random.Range(0, spawners.Length);
            Spawner currentSpawner = spawners[keyRandomSpawner];
            currentSpawner.CreateEnemy();
            yield return new WaitForSeconds(2F);
        }
    }

    void Start()
    {
        _spawners = gameObject.GetComponentsInChildren<Spawner>();
        StartCoroutine(CreateEnemyRandomSpawner(_spawners));
    }
}
