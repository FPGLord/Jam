
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRestart : MonoBehaviour
{
   [SerializeField] private PointsCounter _pointsCounter;
   [SerializeField] private Timer _timer;
   
   
   public void RestartGame()
   {
      Time.timeScale = 1;
      _pointsCounter.PointsAmount = 0;
      _timer.TimeStart = 60;
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }

   
}
