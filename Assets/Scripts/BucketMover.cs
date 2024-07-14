using UnityEngine;
using UnityEngine.InputSystem;


public class BucketMover : MonoBehaviour
{
    [SerializeField] private float _minXPosition, _maxXPosition, _moveSpeed;
    [SerializeField] private Rigidbody2D _rigidbody;
    
   

    private float _moveDirection;

    private void Update()
    {
        Move(_moveDirection);
    }

    private void Move(float direction)
    {
        Vector2 newPosition = _rigidbody.position + new Vector2(direction * _moveSpeed, 0);
        newPosition.x = Mathf.Clamp(newPosition.x, _minXPosition, _maxXPosition);
        _rigidbody.MovePosition(newPosition);
    }

    public void OnMove(InputAction.CallbackContext _value)
    {
        _moveDirection = _value.ReadValue<float>();
    }

    public void MoveTest(Vector3 targetPosition)
    {
        print($"Move Bucket {targetPosition}");
    }
}