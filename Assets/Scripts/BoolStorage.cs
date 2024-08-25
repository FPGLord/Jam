using UnityEngine;

public class BoolStorage: ScriptableObject
{
    [SerializeField] private bool _value;
    
   public bool Value
   {
       get => _value;
       set => _value = value;
   }
    
}
