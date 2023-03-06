using UnityEngine;

public class ForceSingleInstance : MonoBehaviour {

    // --- Private Declarations ---
    [SerializeField] private bool _dontKeepOriginal;
    

    // --- Core Functions ---
    private void Start() {
        GameObject[] otherInstances = GameObject.FindGameObjectsWithTag(this.tag);
        
        foreach (GameObject otherInstance in otherInstances) {
            if(otherInstance != this.gameObject) {
                if(_dontKeepOriginal) {
                    GameObject.Destroy(otherInstance.gameObject);

                } else {
                    GameObject.Destroy(this.gameObject);
                }
            }
        }
    }

}
