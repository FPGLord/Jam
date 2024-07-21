
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class PointsCounterView : MonoBehaviour
{
    [FormerlySerializedAs("_pointsCounter")] [SerializeField] private IntStorage intStorage;
    [SerializeField] private TextMeshProUGUI _textView;
   
    

    private void OnEnable()
    {
        intStorage.onValueChange += UpdateText;
    }

    private void OnDisable()
    {
        intStorage.onValueChange -= UpdateText;
    }

    private void UpdateText()
    {
           _textView.text = $"{intStorage.Value}";
    }
}