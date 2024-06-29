using System;
using UnityEngine;


public class BucketMover : MonoBehaviour
{
    [SerializeField] private float _minXPosition;
    [SerializeField] private float _maxXPosition;
  
  

    private void FixedUpdate()
    {
        MouseMove();
    }

    private void MouseMove()
    {
        Vector3 mouseScreenPosition = Input.mousePosition;
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(mouseScreenPosition);

        mouseWorldPosition.z = transform.position.z;

        transform.position = new Vector3(mouseWorldPosition.x, transform.position.y, transform.position.z);
        
        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, _minXPosition, _maxXPosition);
        transform.position = position;
    }

    
}