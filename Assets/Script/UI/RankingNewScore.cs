using UnityEngine;

public class RankingNewScore : MonoBehaviour {

    // --- Private Declarations ---
    [SerializeField] private DynamicText _scoreText, _nameText;
    [SerializeField] private RankingController _rankingController;
    private Score _score;
    private string _id;


    // --- Core Functions ---
    private void Start() {
        int totalScore = GetScore();
        string lastPlayer = GetLastPlayerName();

        _scoreText.UpdateText(totalScore);
        _nameText.UpdateText(lastPlayer);
        _id = _rankingController.AddScoreToList(lastPlayer, totalScore);
    }

    

    // --- Functions ---
    private int GetScore() {
        _score = GameObject.FindObjectOfType<Score>();

        int totalScore = 0;
        if (_score != null) {
            totalScore = _score.TotalScore;
        }

        return totalScore;
    }

    private static string GetLastPlayerName() {
        if(PlayerPrefs.HasKey("LastPlayer")) {
            return PlayerPrefs.GetString("LastPlayer");
        
        } else {
            return "- YOUR NAME -";
        }
    }

    public void ChangeName(string newName) {
        _rankingController.ChangeName(_id, newName);
        PlayerPrefs.SetString("LastPlayer", newName);
    }

}
