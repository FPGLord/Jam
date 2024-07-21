using UnityEngine;
using UnityEngine.Events;

public class CollisionTrigger : MonoBehaviour
{
    [SerializeField] private UnityEvent<Collider2D> _onTrigger;
   
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        _onTrigger.Invoke(other);
    }
}
