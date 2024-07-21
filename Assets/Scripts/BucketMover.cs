using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.InputSystem;


public class BucketMover : MonoBehaviour
{
    [SerializeField] private float _minXPosition, _maxXPosition, _moveSpeed, _speedToBomb;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private Camera _camera;

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

    public void SetMoveValue(InputAction.CallbackContext _value)
    {
        _moveDirection = _value.ReadValue<float>();
    }

    public void MoveToBomb(Vector3 targetPosition)
    {
        transform.DOMove(new Vector3(targetPosition.x, transform.position.y), 1 / _speedToBomb);
        transform.DORotate(new Vector3(180, transform.rotation.y, transform.rotation.z), 1 / _speedToBomb);
        StartCoroutine(SetStandartRotation());
    }

    private IEnumerator SetStandartRotation()
    {
        _playerInput.DeactivateInput();
        Cursor.visible = false;
        yield return new WaitForSeconds(1f);
        _camera.transform.DOShakePosition(2f, 13, 40);
        yield return new WaitForSeconds(2f);
        transform.DORotate(new Vector3(0, transform.rotation.y, transform.rotation.z), 1 / _speedToBomb);
        _playerInput.ActivateInput();
        Cursor.visible = true;
    }
}