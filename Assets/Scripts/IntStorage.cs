using System;


public class IntStorage: ValueStorage<int>
{
    public event Action onValueChange;
 
    public void Add(Data data)
    {
        _value += data.points;
        onValueChange?.Invoke();
    }
    
}
