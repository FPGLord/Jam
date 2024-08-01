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


    //[SerializeField] private float _timeStart;
    // [SerializeField] private TextMeshProUGUI _timerText;
    // [SerializeField] private GameObject _panel;
    //
    //
    // public float TimeStart
    // {
    //     get => _timeStart;
    //     set => _timeStart = value;
    // }
    //
    // private void Start()
    // {
    //     _timerText.text = _timeStart.ToString();
    // }
    //
    // private void Update()
    // {
    //     _timeStart -= Time.deltaTime;
    //     _timerText.text = Mathf.Round(_timeStart).ToString();
    //     EndGame();
    // }
    //
    // public void PauseGame()
    // {
    //     Time.timeScale = 0;
    //     PlayerPrefs.SetFloat("currentTimer", _timeStart);
    // }
    //
    // public void ResumeGame()
    // {
    //     Time.timeScale = 1;
    //     PlayerPrefs.GetFloat("currentTimer");
    // }
    //
    // public void EndGame()
    // {
    //     if (_timeStart <= 0)
    //     {
    //         _panel.SetActive(true);
    //         Time.timeScale = 0;
    //     }
    // }
    //
    // public void ReduceTime()
    // {
    //     _timeStart -= 10;
    //    
    // }
}