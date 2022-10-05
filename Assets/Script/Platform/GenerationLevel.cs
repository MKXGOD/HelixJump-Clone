using UnityEngine;

public class GenerationLevel : MonoBehaviour
{
    [SerializeField] private GameObject[] _platform;

    public int Level { get => PlayerPrefs.GetInt("CountPlatdorm", 0); private set => PlayerPrefs.SetInt("CountPlatdorm", (int)value); }

    private int _countPlatform;
    private float _distancePlatform = 4;
    private float _spawnHeight = 0;
    
    private void Start()
    {
        _countPlatform = Random.Range(12, 30);
        GenerateLevel();   
    }
    private void GenerateLevel()
    {
            SpawnPlatforms(0);
        for (int i = 0; i < _countPlatform; i++)
            SpawnPlatforms(Random.Range(0, _platform.Length - 1));
            SpawnPlatforms(_platform.Length - 1);
    }
    private void SpawnPlatforms(int platformIndex)
    { 
       GameObject platform =  Instantiate(_platform[platformIndex], transform.up * _spawnHeight, Quaternion.Euler(0, Random.Range(0, 360), 0));
        platform.transform.parent = transform;
        _spawnHeight -= _distancePlatform;
    }

    public void IncreaseLevel()
    {
        Level++;
    }
}
