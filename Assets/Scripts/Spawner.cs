using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoints;
    [SerializeField] private Enemy[] _prefabs;

    private Transform[] _points;

    private void Start()
    {
        _points = new Transform[_spawnPoints.childCount];

        for (int i = 0; i<_spawnPoints.childCount; i++)
        {
            _points[i] = _spawnPoints.GetChild(i);
        }

        StartCoroutine(Spawn(10,2));
    }

    private IEnumerator Spawn(int quantityEnemies, float delay)
    {
        var waitForSecond = new WaitForSeconds(delay);

        for (int i = 0; i< quantityEnemies; i++)
        {
            int position = Random.Range(0, _points.Length);

            int number = Random.Range(0, _prefabs.Length);

            Instantiate(_prefabs[number], _points[position].transform.position, Quaternion.identity);

            yield return waitForSecond;
        }
    }
}