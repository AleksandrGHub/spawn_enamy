using System.Collections;
using UnityEngine;

public class SpawnPoints : MonoBehaviour

{
    [SerializeField] private Transform _pointsSpawn;

    private Transform[] _point;

    private Object[] _enamy;

    private void Start()
    {
        _enamy = Resources.LoadAll("Prefab", typeof(GameObject));

        _point = new Transform[_pointsSpawn.childCount];

        for (int i = 0; i<_pointsSpawn.childCount; i++)
        {

            _point[i] = _pointsSpawn.GetChild(i);

        }

        StartCoroutine(SpawnEnamy());

    }
    private IEnumerator SpawnEnamy()
    {
        for (int i = 0; i < 10; i++)
        {

            Instantiate(_enamy[Random.Range(0, _enamy.Length)], _point[Random.Range(0, _point.Length)].transform.position, Quaternion.identity);

            yield return new WaitForSeconds(2);

        }

    }
}