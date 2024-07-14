using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private Data[] _data;
    [SerializeField] private View _viewPrefab;

    private float spawnSum;


    private void Start()
    {
        SumSpawnChances();
        StartCoroutine(SpawnCoroutine());
    }


    public void Spawn()
    {
        float randomValue = Random.Range(0, spawnSum);
        float temp = 0;
       
        for (int i = 0; i < _data.Length; i++)
        {
            if (randomValue <= _data[i].spawnChance)
            {
                int randomSpawnPoint = Random.Range(0, _spawnPoints.Length);
                View newView = Instantiate(_viewPrefab, _spawnPoints[randomSpawnPoint].transform.position,
                    Quaternion.identity);
                newView.ViewData(_data[i]);
            }
            temp += _data[i].spawnChance;
        }
    }

    private void SumSpawnChances()
    {
        foreach (var item in _data)
        {
            spawnSum += item.spawnChance;
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
}