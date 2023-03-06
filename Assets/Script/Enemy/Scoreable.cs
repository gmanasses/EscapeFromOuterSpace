using UnityEngine;

public class Scoreable : MonoBehaviour {

    // --- Private Declarations ---
    private Score _score;


    // --- Functions ---
    public void SetScore(Score score) {
        _score = score;
    }

    public void ToScore() {
        this._score.AddScore();
    }

}
