using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    [SerializeField] private MovebleObjects _objects;
    [SerializeField] private float _spawnTime;

    private void OnEnable()
    {
        StartCoroutine(Creator());
    }

    public IEnumerator Creator()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(_spawnTime);
            Instantiate(_objects, transform.position, Quaternion.identity, transform);
        }
    }
}
