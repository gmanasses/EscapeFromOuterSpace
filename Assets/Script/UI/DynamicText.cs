using UnityEngine;
using UnityEngine.UI;

public class DynamicText : MonoBehaviour {

    // --- Private Declarations ---
    private Text _text;


    // --- Core Functions ---
    private void Awake() {
        _text = this.GetComponent<Text>();
    }


    // --- Functions ---
    public void UpdateText(int number) {
        _text.text = number.ToString();
    }

}
