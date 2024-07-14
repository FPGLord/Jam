
using UnityEngine;
using UnityEngine.Events;

public class GlobalEvent : ScriptableObject
{
    public UnityEvent OnInvoke;
    
    public void Invoke()
    {
        OnInvoke.Invoke();
    }
}

public class GlobalEvent<T> : ScriptableObject
{
    public UnityEvent<T> OnInvoke;
    
    public void Invoke(T parameter)
    {
        OnInvoke.Invoke(parameter);
    }
    
}
