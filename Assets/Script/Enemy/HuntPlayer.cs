using UnityEngine;

public class HuntPlayer : MonoBehaviour {

    // --- Private Declarations ---
    [SerializeField] private Transform _target;
    [SerializeField] private float _huntForce;
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


    // --- Functions ---
    public void SetTarget(Transform target) {
        _target = target;
    }

}
