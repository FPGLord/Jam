using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private Objects[] _gameObjects;
    [SerializeField] private GameObject _viewPrefab;
   
    private List<GameObject> _spawnViews = new();
    private int _index;


    private void Start()
    {
        Spawn();
        ShuffleSpawnPoints();
        StartCoroutine(SpawnCoroutine());
    }

    public void Spawn()
    {
        foreach (var item in _spawnViews)
        {
            item.SetActive(true);
        }

        for (int i = 0; i < _gameObjects.Length; i++)
        {
            if (_spawnViews.Count <=1)
            {
                GameObject newView = Instantiate(_viewPrefab, transform);
                _spawnViews.Add(newView);
            }
        }
        
    }

    
    
    private void ShuffleSpawnPoints()
    {
        for (int i = 0; i < _spawnPoints.Length; i++)
        {
            int randomObstacleIndex = Random.Range(0, _spawnPoints.Length);
            (_spawnPoints[i], _spawnPoints[randomObstacleIndex]) =
                (_spawnPoints[randomObstacleIndex], _spawnPoints[i]);
        }
    }

    IEnumerator SpawnCoroutine()
    {
        while (_index ==7)
        {
            Spawn();
            yield return new WaitForSeconds(3f);
            _index++;
            Spawn();
        }
    }
   
}