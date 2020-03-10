using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _delay;
    [SerializeField] private GameObject _enemyExample;
    [SerializeField] private Text _timeText;
    private float _lastSpawn;
    private Transform[] _spawnDots;
    
    void Start()
    {
        _spawnDots = GetComponentsInChildren<Transform>();
    }

    void Update()
    {
        _timeText.text = Mathf.Ceil(Time.time).ToString();
        if (_lastSpawn >= _delay)
        {
            foreach(Transform spawnDot in _spawnDots)
            {
                Instantiate(_enemyExample, spawnDot);
            }
            _lastSpawn = 0;
        }
        _lastSpawn += Time.deltaTime;
    }
}
