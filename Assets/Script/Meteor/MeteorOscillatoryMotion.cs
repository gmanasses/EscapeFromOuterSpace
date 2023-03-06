using UnityEngine;

public class MeteorOscillatoryMotion : MonoBehaviour {

    // --- Private Declarations ---
    [SerializeField] private float _amplitude;
    [SerializeField][Range(0, 0.1f)] private float _velocity;
    private Vector3 _initalPosition;
    private float _angle;


    // --- Core Functions ---
    private void Awake() {
        _initalPosition = this.transform.position;
    }

    private void Update() {
        _angle += _velocity;
        float variation = Mathf.Sin(_angle);
        this.transform.position = _initalPosition + (_amplitude * variation * Vector3.up);
    }

}
