using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        transform.Translate(0, _speed * Time.deltaTime, 0);
    }
}