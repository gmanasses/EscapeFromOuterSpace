using UnityEngine;

public class RankingNewScore : MonoBehaviour {

    // --- Private Declarations ---
    [SerializeField] private DynamicText _scoreText;
    [SerializeField] private RankingController _rankingController;
    private Score _score;
    private int _id;


    // --- Core Functions ---
    private void Start() {
        _score = GameObject.FindObjectOfType<Score>();

        int totalScore = 0;
        if(_score != null) {
            totalScore = _score.TotalScore;
        }

        _scoreText.UpdateText(totalScore);
        _id = _rankingController.AddScoreToList("Name", totalScore);
    }

    public void ChangeName(string newName) {
        _rankingController.ChangeName(_id, newName);
    }
}
