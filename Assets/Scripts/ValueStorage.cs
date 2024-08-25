using UnityEngine;

public class ValueStorage<T>: ScriptableObject
{
    [SerializeField] protected T _value;

    public T Value
   {
       get => _value;
       set => _value = value;
   }
    
}
