using UnityEngine;

public class MovebleObjects : MonoBehaviour
{
    [SerializeField] private Vector3 _trajectoryMovement;
    private CharacterController _controller;

    public void Inicialize(CharacterController controller)
    {
        _controller = controller;
    }

    protected void Move(float speedMove)
    {
        Vector3 offcset = (_trajectoryMovement).normalized * speedMove * Time.deltaTime;
        _controller.Move(offcset);
    }

    protected void Die(Vector3 startPosition, float lifeDistance)
    {
        if (Vector3.Distance(startPosition, transform.position) > lifeDistance)
            Destroy(gameObject);
    }
}
