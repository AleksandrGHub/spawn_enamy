using System.Collections;
using UnityEngine;

public class SpawnPoints : MonoBehaviour

{
    [SerializeField] private Transform _pointsSpawn;

    private Transform[] _point;

    public GameObject _enemy;

    private int _randomPosition;

    private float _delayBetweenSpawn=2f;

    private float _timeBetweenSpawn;

    private void Start()
    {
        _timeBetweenSpawn = _delayBetweenSpawn;

        _point = new Transform[_pointsSpawn.childCount];

        for (int i = 0; i<_pointsSpawn.childCount; i++)
        {

            _point[i] = _pointsSpawn.GetChild(i);

        }
    }

    private void Update()
    {
        if (_timeBetweenSpawn <= 0)
        {

            _randomPosition = Random.Range(0, _point.Length);

            Instantiate(_enemy, _point[_randomPosition].transform.position, Quaternion.identity);

            _timeBetweenSpawn = _delayBetweenSpawn;

        }
        else
        {
            _timeBetweenSpawn -= Time.deltaTime;

        }
    }
}