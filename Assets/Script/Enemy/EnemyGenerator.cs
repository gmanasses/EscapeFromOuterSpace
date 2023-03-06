using UnityEngine;

public class EnemyGenerator : MonoBehaviour {

    // --- Private Declarations ---
    [SerializeField] private EnemyPool _poolOfEnemies;
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private Score _score;
    [SerializeField] private Transform _playerShipPos;
    [SerializeField] private float _time;
    [SerializeField] private Rect _area;


    // --- Core Functions ---
    private void Start() {
        InvokeRepeating("Instantiate", 0f, _time);
    }

    private void OnDrawGizmosSelected() {
        Gizmos.color = new Color(100, 0, 100);

        Vector3 pos = (Vector3)_area.position + (Vector3)_area.size/2 + this.transform.position;
        Gizmos.DrawWireCube(pos, _area.size);
    }


    // --- Functions ---
    private void Instantiate() {
        if(_poolOfEnemies.thereIsEnemyAvailable()) {
            GameObject enemy = _poolOfEnemies.GetEnemyFromPool();
            SetEnemyPosition(enemy);
            enemy.GetComponent<EnemyController>().SetTarget(_playerShipPos);
            enemy.GetComponent<Scoreable>().SetScore(_score);
        }
    }

    private void SetEnemyPosition(GameObject enemy) {
        float randomPosX = Random.Range(_area.x, _area.x + _area.width);
        float randomPosY = Random.Range(_area.y, _area.y + _area.height);
        Vector2 randomPos = new Vector2(randomPosX, randomPosY);

        Vector3 enemyPos = this.transform.position + (Vector3)randomPos;
        enemy.transform.position = enemyPos;
    }

}
