using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour {

    // --- Private Declarations ---
    [SerializeField] private UnityEvent _whenCrashingTheShip;


    // --- Core Functions ---
    private void OnCollisionEnter2D(Collision2D collision) {
        _whenCrashingTheShip.Invoke();
    }

}
