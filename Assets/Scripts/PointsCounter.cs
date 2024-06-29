using System;
using UnityEngine;


public class PointsCounter : ScriptableObject
{
    public event Action onValueChange;
        
   [SerializeField] private int _pointsAmount;

   public int PointsAmount
   {
       get => _pointsAmount;
       set => _pointsAmount = value;
   }
   
    
    public void AddPoint()
    {
        _pointsAmount++;
        onValueChange?.Invoke();
    }
    
}
