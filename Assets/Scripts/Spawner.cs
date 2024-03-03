using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoints;
    [SerializeField] private Enemy[] _prefabs;

    private Transform[] _points;
    private int _quantityEnemies = 10;
    private float _delay = 2f;

    private void Start()
    {
        _points = new Transform[_spawnPoints.childCount];

        for (int i = 0; i < _spawnPoints.childCount; i++)
        {
            _points[i] = _spawnPoints.GetChild(i);
        }

        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        int minAgel = -3;
        int maxAngel = 20;
        int minIndexPosition = 0;
        int minIndexPrefab = 0;
        var waitForSecond = new WaitForSeconds(_delay);

        for (int i = 0; i < _quantityEnemies; i++)
        {
            int indexPosition = Random.Range(minIndexPosition, _points.Length);

            int indexPrefab = Random.Range(minIndexPrefab, _prefabs.Length);

            int angel = Random.Range(minAgel, maxAngel);

            Instantiate(_prefabs[indexPrefab], _points[indexPosition].transform.position, Quaternion.AngleAxis(angel, Vector3.forward));

            yield return waitForSecond;
        }
    }
}