using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class CollisionTrigger : MonoBehaviour
{
    [SerializeField] private UnityEvent _onTrigger;
   
    public UnityEvent OnTrigger => _onTrigger;

    private void OnCollisionEnter2D()
    {
        _onTrigger.Invoke();
    }
   
}
