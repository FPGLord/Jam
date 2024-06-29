using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private GameObject[] _gameObjects;

    private GameObject[] _objects;
    private List<int> _availableSpawnIndex;

    private void Start()
    {
        _objects = new GameObject[_gameObjects.Length];
        _availableSpawnIndex = new List<int>();
        for (int i = 0; i < _spawnPoints.Length; i++)
        {
            _availableSpawnIndex.Add(i); 
        }

        InstantializeObjects();
        StartCoroutine(SpawnCoroutine());
    }

    private void InstantializeObjects()
    {
        for (int i = 0; i < _gameObjects.Length; i++)
        {
            if (_availableSpawnIndex.Count > 0)
            {
                int spawnIndex = _availableSpawnIndex[Random.Range(0, _availableSpawnIndex.Count)];
                _objects[i] = Instantiate(_gameObjects[i], _spawnPoints[spawnIndex].position, Quaternion.identity);
                _availableSpawnIndex.Remove(spawnIndex); 
            }
        }
    }

    public void RespawnObjects()
    {
        for (int i = 0; i < _spawnPoints.Length; i++)
        {
            if (!_objects.Any(obj => obj.transform.position == _spawnPoints[i].position))
            {
                _availableSpawnIndex.Add(i);
            }
        }

        InstantializeObjects(); 
    }

    IEnumerator SpawnCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            RespawnObjects();
        }
    }


    // [SerializeField] private Transform[] _spawnPoints;
    // [SerializeField] private GameObject[] _gameObjects;
    //
    //
    // private GameObject[] _objects;
    //
    // private void Start()
    // {
    //     Instantiate();
    //     ShuffleSpawnPoints();
    //     StartCoroutine(SpawnCoroutine());
    // }
    //
    //
    // private void SpawnObjects()
    // {
    //     for (int i = 0; i < _objects.Length; i++)
    //     {
    //         _objects[i].transform.position = _spawnPoints[i].position;
    //     }
    // }
    //
    // private void Instantiate()
    // {
    //     _objects = new GameObject[_gameObjects.Length];
    //     for (int i = 0; i < _gameObjects.Length; i++)
    //     {
    //         _objects[i] = Instantiate(_gameObjects[i], transform);
    //         
    //     }
    // }
    //
    // public void RespawnObjects()
    // {
    //     ShuffleSpawnPoints(); 
    //     SpawnObjects();       
    // }
    //
    // IEnumerator SpawnCoroutine()
    // {
    //     while (true)
    //     {
    //         yield return new WaitForSeconds(3f); 
    //         RespawnObjects();                   
    //     }
    // }
    //
    //
    // private void ShuffleSpawnPoints()
    // {
    //     for (int i = 0; i < _spawnPoints.Length; i++)
    //     {
    //         int randomObstacleIndex = Random.Range(0, _spawnPoints.Length);
    //         (_spawnPoints[i], _spawnPoints[randomObstacleIndex]) =
    //             (_spawnPoints[randomObstacleIndex], _spawnPoints[i]);
    //     }
    // }
}