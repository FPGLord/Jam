
using UnityEngine;

public class Objects : ScriptableObject
{
    [SerializeField] private GameObject _gameObject;
    [SerializeField] private int _points;
    [SerializeField] private int _reduceTimePerSeconds;
    [SerializeField] private float _spawnChance;

    public GameObject gameObject => _gameObject;

    public int points => _points;

    public int reduceTimePerSeconds => _reduceTimePerSeconds;

    public float spawnChance => _spawnChance;
}
