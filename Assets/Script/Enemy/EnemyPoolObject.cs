using UnityEngine;

public class EnemyPoolObject : MonoBehaviour {

    // --- Private Declarations ---
    private EnemyPool _myEnemyPool;


    // --- Functions ---
    public void SetEnemyPool(EnemyPool _pool) {
        _myEnemyPool = _pool;
    }

    public void PutEnemyInPoolAgain() {
        _myEnemyPool.PutEnemyInPoolAgain(this.gameObject);
    }

}
