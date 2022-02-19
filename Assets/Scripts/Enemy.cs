using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int _speed;

    private void Start()
    {
        _speed = Random.Range(3, 7);

        Destroy(gameObject, 10f);
    }

    private void Update()
    {
        transform.Translate(_speed * Time.deltaTime, 0, 0);
    }
}