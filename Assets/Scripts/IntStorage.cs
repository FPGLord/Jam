using System;
using UnityEngine;
using UnityEngine.Serialization;


public class IntStorage : ScriptableObject
{
    public event Action onValueChange;
        
   [FormerlySerializedAs("_vaule")] [FormerlySerializedAs("_pointsAmount")] [SerializeField] private int _value;

   public int Value
   {
       get => _value;
       set => _value = value;
   }
   
    
    public void Add()
    {
        _value++;
        onValueChange?.Invoke();
    }
    
}
