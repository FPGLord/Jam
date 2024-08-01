using TMPro;
using UnityEngine;


public class IntStorageView : MonoBehaviour
{
    [SerializeField] private IntStorage intStorage;
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