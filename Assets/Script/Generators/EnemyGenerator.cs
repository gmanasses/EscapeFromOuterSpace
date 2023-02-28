using System.Collections;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {

    // --- Private Declarations ---
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private float _time;
    [SerializeField] private float _radius;


    // --- Core Functions ---
    private void Start() {
        StartCoroutine(StartGeneration());
    }


    // --- Functions ---
    private IEnumerator StartGeneration() {
        while(true) {
            yield return new WaitForSeconds(_time);
            Instantiate();
        }
    }

    private void Instantiate() {
        GameObject enemy = GameObject.Instantiate(_enemyPrefab);
        SetEnemyPosition(enemy);
    }

    private void SetEnemyPosition(GameObject enemy) {
        Vector3 randomPosition = new Vector3(Random.Range(-_radius, _radius), Random.Range(-_radius, _radius), 0);

        Vector3 enemyPos = this.transform.position + randomPosition;
        enemy.transform.position = enemyPos;
    }

}
