﻿using UnityEngine;

public class EnemyGenerator : MonoBehaviour {

    // --- Private Declarations ---
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private Score _score;
    [SerializeField] private Transform _playerShipPos;
    [SerializeField] private float _radius;
    [SerializeField] private float _time;


    // --- Core Functions ---
    private void Start() {
        InvokeRepeating("Instantiate", 0f, _time);
    }


    // --- Functions ---
    private void Instantiate() {
        GameObject enemy = GameObject.Instantiate(_enemyPrefab);
        SetEnemyPosition(enemy);
        enemy.GetComponent<HuntPlayer>().SetTarget(_playerShipPos);
        enemy.GetComponent<Scoreable>().SetScore(_score);
    }

    private void SetEnemyPosition(GameObject enemy) {
        Vector3 randomPosition = new Vector3(Random.Range(-_radius, _radius), Random.Range(-_radius, _radius), 0);

        Vector3 enemyPos = this.transform.position + randomPosition;
        enemy.transform.position = enemyPos;
    }

}
