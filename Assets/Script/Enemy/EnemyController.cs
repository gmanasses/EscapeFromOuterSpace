using UnityEngine;
using UnityEngine.Events;

public class EnemyController : MonoBehaviour {

    // --- Private Declarations ---
    [SerializeField] private UnityEvent _whenCollides;


    // --- Core Functions ---
    private void OnCollisionEnter2D(Collision2D collision) {
        _whenCollides.Invoke();
    }


    // --- Functions ---
    public void DestroyEnemy() {
        Destroy(this.gameObject);
    }

}
