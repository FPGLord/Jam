using System;
using TMPro;
using UnityEngine;

public class PointsCounterView : MonoBehaviour
{
    [SerializeField] private PointsCounter _pointsCounter;
    [SerializeField] private TextMeshProUGUI _textView;
   
    

    private void OnEnable()
    {
        _pointsCounter.onValueChange += UpdateText;
    }

    private void OnDisable()
    {
        _pointsCounter.onValueChange -= UpdateText;
    }

    private void UpdateText()
    {
           _textView.text = $"{_pointsCounter.PointsAmount}";
    }
}