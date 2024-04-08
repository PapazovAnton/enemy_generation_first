using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScheduler : MonoBehaviour
{
    private Spawner[] _spawners;
    private EnemyPool _enemyPool;

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

    private void Awake()
    {
        _enemyPool = FindObjectOfType<EnemyPool>();
    }

    private void Start()
    {
        _spawners = GetComponentsInChildren<Spawner>();

        foreach (var spawner in _spawners)
        {
            spawner.Init(_enemyPool);
        }

        StartCoroutine(CreateEnemyRandomSpawner(_spawners));
    }
}
