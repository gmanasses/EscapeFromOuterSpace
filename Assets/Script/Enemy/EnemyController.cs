using UnityEngine;
using UnityEngine.Events;

public class EnemyController : MonoBehaviour {

    // --- Private Declarations ---
    [SerializeField] private float _huntForce;
    [SerializeField] private Transform _target;
    [SerializeField] private UnityEvent _whenCollides;
    private Rigidbody2D _rigidbody;


    // --- Core Functions ---
    private void Awake() {
        _rigidbody = this.GetComponent<Rigidbody2D>();
    }
    
    private void FixedUpdate() {
        Vector3 displacementVector = _target.position - this.transform.position;
        displacementVector = displacementVector.normalized;
        displacementVector *= _huntForce;

        _rigidbody.AddForce(displacementVector, ForceMode2D.Force);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        _whenCollides.Invoke();
    }


    // --- Functions ---
    public void DestroyEnemy() {
        Destroy(this.gameObject);
    }

    public void SetTarget(Transform target) {
        _target = target;
    }

}
