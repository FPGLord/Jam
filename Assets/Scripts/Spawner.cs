using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private Data[] _data;
    [SerializeField] private View _viewPrefab;
    [SerializeField] private int _maxObjectsCount;

    private List<View> _objectsPool = new();
    private float _spawnChancesSum;


    private void Start()
    {
        Instantiate();
        SumSpawnChances();
        StartCoroutine(SpawnCoroutine());
    }


    public void Instantiate()
    {
        for (var i = 0; i < _data.Length; i++)
        {
            View newView = Instantiate(_viewPrefab);
            newView.ViewData(_data[i]);
            _objectsPool.Add(newView);
            newView.SetActive(false);
        }
    }

    private void SumSpawnChances()
    {
        foreach (var item in _data)
        {
            _spawnChancesSum += item.spawnChance;
        }
    }

    IEnumerator SpawnCoroutine()
    {
        while (true)
        {
            Spawn();
            yield return new WaitForSeconds(1f);
        }
    }

    private void Spawn()
    {
        var randomValue = Random.Range(0, _spawnChancesSum);

        int objectsCount = Random.Range(0, _maxObjectsCount);

        while (_objectsPool.Count < _maxObjectsCount)
        {
            Instantiate();
        }


        for (int i = 0; i < objectsCount; i++)
        {
            int randomSpawnPoint = Random.Range(0, _spawnPoints.Length);
            _objectsPool[0].SetPosition(_spawnPoints[randomSpawnPoint].transform.position);
            _objectsPool[0].SetActive(true);
            _objectsPool.Remove(_objectsPool[0]);
        }
    }
}