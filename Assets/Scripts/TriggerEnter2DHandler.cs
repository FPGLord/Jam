using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class TriggerEnter2DHandler : MonoBehaviour
{
    [FormerlySerializedAs("_onTrigger")] [SerializeField] private UnityEvent<Collider2D> _onTriggerEnter;
   
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        _onTriggerEnter.Invoke(other);
    }
}
