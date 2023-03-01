using UnityEngine;
using UnityEngine.SceneManagement;

public class ReadScene : MonoBehaviour {

    // --- Functions ---
	public void LoadScene(string scene) {
        SceneManager.LoadScene(scene);
    }

}
