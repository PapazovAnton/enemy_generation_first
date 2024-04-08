using System.Collections.Generic;
using UnityEngine;

public class EnemyPool : MonoBehaviour
{
    [SerializeField] private Enemy _prefab;

    private List<Enemy> _pool = new List<Enemy>();

    private void Awake()
    {
        CreateEnemy();
    }

    public Enemy GetFreeEnemy()
    {
        return (TryGetEnemy(out Enemy enemy)) ? enemy : CreateEnemy();
    }

    private bool TryGetEnemy(out Enemy enemy)
    {
        foreach (var item in _pool)
        {
            if (!item.gameObject.activeInHierarchy)
            {
                enemy = item;
                enemy.gameObject.SetActive(true);
                return true;
            }
        }

        enemy = null;
        return false;
    } 

    private Enemy CreateEnemy()
    {
        Enemy enemy = Instantiate(_prefab);
        enemy.gameObject.SetActive(false);
        
        _pool.Add(enemy);
        return enemy;
    }
}