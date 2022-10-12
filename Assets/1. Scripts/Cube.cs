using UnityEngine;

public class Cube : MovebleObjects
{
    [SerializeField] private float _cubeLifeDistance ;
    [SerializeField] private float _cubeSpeedMove;
    private CharacterController _cubeControler;
    private Vector3 _startPosition;

    private void Start()
    {
        _startPosition = transform.position;
        _cubeControler = GetComponent<CharacterController>();
        Inicialize(_cubeControler);
        EventManager.SpeedMove += SetSpeedMove;
        EventManager.DistanseLife += SetLifeDistance;
    }
    private void Update()
    {
        Move(_cubeSpeedMove);
        Die(_startPosition, _cubeLifeDistance);
    }

    private void SetSpeedMove(string value)
    {
        float newSpeed = float.Parse(value);
        _cubeSpeedMove = newSpeed;
        Saver.Save(nameof(_cubeSpeedMove), newSpeed);
    }

    private void SetLifeDistance(string value)
    {
        float newLifeDistance = float.Parse(value);
        _cubeLifeDistance = newLifeDistance;
        Saver.Save(nameof(_cubeLifeDistance), newLifeDistance);
    }

    private void OnEnable()
    {
        LoadValue();
    }

    private void LoadValue()
    {
        _cubeLifeDistance = Saver.Load(nameof(_cubeLifeDistance));
        _cubeSpeedMove = Saver.Load(nameof(_cubeSpeedMove));
    }
}
