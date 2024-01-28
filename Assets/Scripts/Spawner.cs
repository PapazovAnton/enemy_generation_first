using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;

    public void CreateEnemy()
    {
        Instantiate(_enemy, transform.position, Quaternion.Euler(0, 0, Random.Range(0, 360)));
    }
}
