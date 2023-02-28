using UnityEngine;

public class MouseFollower : MonoBehaviour {

    // --- Core Functions ---
    void Update() {
        Vector2 position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = position;
    }

}
