using UnityEngine;

public class Cube : MovebleObjects
{
    private CharacterController _cubeControler;
    private Vector3 _startPosition;
    [SerializeField] private float _cubeLifeDistance;
    [SerializeField] private float _cubeSpeedMove;

    private void Start()
    {
        _startPosition = transform.position;
        _cubeControler = GetComponent<CharacterController>();
        Inicialize(_cubeControler);
    }

    private void Update()
    {
        Move(_cubeSpeedMove);
        Die(_startPosition, _cubeLifeDistance);
    }
}
