using UnityEngine;



public class BucketMover : MonoBehaviour
{
    [SerializeField] private float _minXPosition, _maxXPosition;
    [SerializeField] private Rigidbody2D _rigidbody;

    private void FixedUpdate()
    {
        MouseMove();
    }

    private void MouseMove()
    {
        Vector3 mouseScreenPosition = Input.mousePosition;
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(mouseScreenPosition);

        mouseWorldPosition.x = Mathf.Clamp(mouseWorldPosition.x, _minXPosition, _maxXPosition);
        mouseWorldPosition.z = transform.position.z;

        _rigidbody.MovePosition(new Vector3(mouseWorldPosition.x, transform.position.y, transform.position.z));
    }
}