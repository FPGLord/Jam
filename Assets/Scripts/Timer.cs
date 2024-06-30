using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private float _timeStart;
    //[SerializeField] private Text _timerText;
    [SerializeField] private TextMeshPro _timerText;
    [SerializeField] private GameObject _panel;

    
    
    public float TimeStart
    {
        get => _timeStart;
        set => _timeStart = value;
    }

    private void Start()
    {
        _timerText.text = _timeStart.ToString();
    }

    private void Update()
    {
        _timeStart -= Time.deltaTime;
        _timerText.text = Mathf.Round(_timeStart).ToString();
        EndGame();
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        PlayerPrefs.SetFloat("currentTimer",_timeStart);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        PlayerPrefs.GetFloat("currentTimer");
    }

    public void EndGame()
    {
        if (_timeStart <= 0)
        {
            _panel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}