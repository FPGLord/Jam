
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class GameRestart : MonoBehaviour
{
   [FormerlySerializedAs("_pointsCounter")] [SerializeField] private IntStorage intStorage;
   [SerializeField] private Timer _timer;
   
   
   public void RestartGame()
   {
      Time.timeScale = 1;
      intStorage.Value = 0;
      _timer.TimeStart = 60;
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }

   
}
