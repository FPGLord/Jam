using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [FormerlySerializedAs("_gameObjects")] [SerializeField] private Data[] _data;
    [SerializeField] private View _viewPrefab;
    
   

    private void Start()
    {
        StartCoroutine(SpawnCoroutine());
    }

    public void Spawn()
    {

        for (int i = 0; i < _spawnPoints.Length; i++)
        {
                View newView = Instantiate(_viewPrefab, _spawnPoints[i].transform.position, Quaternion.identity);
                newView.ViewData(_data[Random.Range(0,_data.Length)]);
        }
        
    }

    IEnumerator SpawnCoroutine()
    {
        while (true)
        {
            Spawn();
            yield return new WaitForSeconds(3f);
        }
    }
   
}