using System.Collections.Generic;
using UnityEngine;

public class EnemyPool : MonoBehaviour {

    // --- Private Declarations ---
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private int _amountOfEnemyToSpawn;
    private Stack<GameObject> _poolOfEnemies;


    // --- Core Functions ---
    private void Start() {
        _poolOfEnemies = new Stack<GameObject>();
        CreateAllSceneEnemies();
    }


    // --- Core Functions ---
    private void CreateAllSceneEnemies() {
        for(int i=0; i<_amountOfEnemyToSpawn; i++) {
            GameObject enemy = GameObject.Instantiate(_enemyPrefab, this.transform);
            enemy.SetActive(false);

            EnemyPoolObject enemyPoolObj = enemy.GetComponent<EnemyPoolObject>();
            enemyPoolObj.SetEnemyPool(this);

            _poolOfEnemies.Push(enemy);
        }
    }

    public GameObject GetEnemyFromPool() {
        GameObject enemy = _poolOfEnemies.Pop();
        enemy.SetActive(true);

        return enemy;
    }

    public void PutEnemyInPoolAgain(GameObject enemy) {
        enemy.SetActive(false);
        _poolOfEnemies.Push(enemy);
    }

    public bool thereIsEnemyAvailable() {
        return _poolOfEnemies.Count > 0;
    }

}
