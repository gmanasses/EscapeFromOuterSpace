using UnityEngine;

public class AudioManager : MonoBehaviour {

    // --- Core Functions ---
    void Awake() {
        DontDestroyOnLoad(this.gameObject);
    }

}
