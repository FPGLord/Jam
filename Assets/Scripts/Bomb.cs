
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] private Timer _timer;
    [SerializeField] private int _timeReduce;
    [SerializeField] private GameObject _gameObject;

    public void ReduceTime()
    {
        if (_gameObject.layer == LayerMask.NameToLayer("Bomb"))
        {
            _timer.TimeStart -= _timeReduce;
        }
    }
}