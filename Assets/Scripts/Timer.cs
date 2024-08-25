using System.Collections;
using UnityEngine;
using UnityEngine.Events;


public class Timer : MonoBehaviour
{
    [SerializeField] private UnityEvent _OnTick;
    private int _timeLimit = 60;


    private void Start()
    {
        StartCoroutine(TickCoroutine());
    }

    IEnumerator TickCoroutine()
    {
        for (int i = 0; i < _timeLimit; i++)
        {
            var waitForSeconds = new WaitForSeconds(1f);
            yield return waitForSeconds;
            Tick();
        }
    }

    public void Tick()
    {
        _OnTick.Invoke();
    }
}