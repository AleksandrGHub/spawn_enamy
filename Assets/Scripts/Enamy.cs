using UnityEngine;

public class Enamy : MonoBehaviour
{
    private int _speed;

    private void Start()
    {
        _speed = Random.Range(3,7);

        Destroy(gameObject, 8f);
    }
    private void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, transform.position + transform.right, _speed * Time.deltaTime);

    }
}