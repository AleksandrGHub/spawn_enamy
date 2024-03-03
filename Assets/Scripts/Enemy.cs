using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int _speed;
    private int _minSpeed = 3;
    private int _maxSpeed = 7;
    private float _destructionTime = 10f;

    private void Start()
    {
        _speed = Random.Range(_minSpeed, _maxSpeed);

        Destroy(gameObject, _destructionTime);
    }

    private void Update()
    {
        transform.Translate(_speed * Time.deltaTime, 0, 0);
    }
}