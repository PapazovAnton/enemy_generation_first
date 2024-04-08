using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }

    private void Update()
    {
        transform.Translate(0, _speed * Time.deltaTime, 0);
    }
}