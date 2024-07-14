using UnityEngine;
using UnityEngine.Events;

public class GlobalEventHandler<T> : MonoBehaviour
{
    [SerializeField] private GlobalEvent<T> globalEvent;
    [SerializeField] private UnityEvent<T> _OnInvoke;
    private void OnEnable()
    {
        globalEvent.OnInvoke.AddListener(Invoke);
      
    }
    private void OnDisable()
    {
        globalEvent.OnInvoke.RemoveListener(Invoke) ;
    }

    void Invoke(T parameter)
    {
        _OnInvoke.Invoke(parameter);
    }
}
