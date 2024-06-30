using System;
using UnityEngine;


public class BucketMover : MonoBehaviour
{
    [SerializeField] private float _minXPosition;
    [SerializeField] private float _maxXPosition;
    private Rigidbody2D _rigidbody2D;
    
    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    
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
        
        _rigidbody2D.MovePosition(new Vector3(mouseWorldPosition.x, transform.position.y, transform.position.z));
    
     }

    
}