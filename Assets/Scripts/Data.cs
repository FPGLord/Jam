using UnityEngine;

public class Data : ScriptableObject
{
    [field: SerializeField] public Sprite sprite { get; private set; }
    [field: SerializeField] public int points { get; private set; }
    [field: SerializeField] public float fallSpeed { get; private set; }
    [field: SerializeField] public float spawnChance{ get; private set; }
    
}