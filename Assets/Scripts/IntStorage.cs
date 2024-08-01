using System;
using UnityEngine;

public class IntStorage: ScriptableObject
{
    [SerializeField] private int _value;
    public event Action onValueChange;


   public int Value
   {
       get => _value;
       set => _value = value;
   }
   
    
    public void Add(Data data)
    {
        _value += data.points;
        onValueChange?.Invoke();
    }
    
}
