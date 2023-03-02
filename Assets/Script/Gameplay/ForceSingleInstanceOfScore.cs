using UnityEngine;

public class ForceSingleInstanceOfScore : MonoBehaviour {

    // --- Core Functions ---
    private void Start() {
        GameObject[] otherInstances = GameObject.FindGameObjectsWithTag(this.tag);
        
        foreach (GameObject otherInstance in otherInstances) {
            if(otherInstance != this.gameObject) { 
                GameObject.Destroy(otherInstance.gameObject);
            }
        }
    }
}
