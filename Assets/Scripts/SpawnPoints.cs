using System.Collections;
using UnityEngine;

public class SpawnPoints : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoints;
    [SerializeField] private Enemy[] _enemys;

    private Transform[] _points;

    private void Start()
    {
        _points = new Transform[_spawnPoints.childCount];

        for (int i = 0; i<_spawnPoints.childCount; i++)
        {
            _points[i] = _spawnPoints.GetChild(i);
        }

        StartCoroutine(SpawnEnemy(10,2));
    }

    private IEnumerator SpawnEnemy(int numberEnemies,float delayBetweenSpawn)
    {
        for (int i = 0; i< numberEnemies; i++)
        {
            int randomPosition = Random.Range(0, _points.Length);

            int randomEnemy = Random.Range(0, _enemys.Length);

            Instantiate(_enemys[randomEnemy], _points[randomPosition].transform.position, Quaternion.identity);

            yield return new WaitForSeconds(delayBetweenSpawn);
        }
    }
}