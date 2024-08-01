using TMPro;
using UnityEngine;


    public class GameTime : MonoBehaviour
    {
        [SerializeField] private int _time;
        [SerializeField] private TextMeshProUGUI _timer;
        
        public void ReduceTime()
        {
            _time--;
            _timer.text = _time.ToString();
        }

        public void ReduceBombTime()
        {
            _time -= 10;
        }
    }
