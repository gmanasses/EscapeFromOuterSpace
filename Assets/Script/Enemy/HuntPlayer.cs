using UnityEngine;

public class HuntPlayer : MonoBehaviour {

    // --- Private Declarations ---
    [SerializeField] private Transform _target;
    [SerializeField] private float _huntSpeed;


    // --- Core Functions ---
    private void Update() {
        Vector3 displacementVector = _target.position - this.transform.position;
        displacementVector = displacementVector.normalized;
        displacementVector *= _huntSpeed;
        this.transform.position += displacementVector * Time.deltaTime;
    }


    // --- Functions ---
    public void SetTarget(Transform target) {
        _target = target;
    }
}
