using UnityEngine;
using UnityEngine.Events;

public class TriggerEnter2DHandler : MonoBehaviour
{
    [SerializeField] private UnityEvent<Collider2D> _onTriggerEnter;
   
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        _onTriggerEnter.Invoke(other);
    }
}
