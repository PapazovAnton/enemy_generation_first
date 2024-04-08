using UnityEngine;

public class Spawner : MonoBehaviour
{
    private Enemy _enemy;
    private EnemyPool _pool;

    public void CreateEnemy()
    {
        _enemy = _pool.GetFreeEnemy();
        _enemy.transform.position = transform.position;
        _enemy.transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 360));
        _enemy.gameObject.SetActive(true);
    }

    public void Init(EnemyPool pool)
    {
        _pool = pool;
    }
}
