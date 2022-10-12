using UnityEngine;
using System.Collections;
using Lean.Pool;

public class Spawner : MonoBehaviour
{
    [SerializeField] private MovebleObjects _objects;
    [SerializeField] private float _spawnTime;
    private Coroutine _creatorCorutine;

    private void OnEnable()
    {
        EventManager.SpeedRespawn += SetSpawnTime;
        _creatorCorutine = StartCoroutine(Creator());
    }

    public IEnumerator Creator()
    {
        while (true)
        {
            LeanPool.Spawn(_objects, transform.position, Quaternion.identity, transform);
            yield return new WaitForSecondsRealtime(_spawnTime);
        }
    }

    private void SetSpawnTime(string value)
    {
        StopCoroutine(_creatorCorutine);
        _spawnTime = float.Parse(value);
        _creatorCorutine = StartCoroutine(Creator());
    }
}
