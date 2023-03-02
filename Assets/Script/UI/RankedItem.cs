using UnityEngine;
using UnityEngine.UI;

public class RankedItem : MonoBehaviour {

    // --- Private Declarations ---
    [SerializeField] private Text _textRanking, _textName, _textScore;


    // --- Functions ---
    public void ConfigureText(int ranking, int score, string name) {
        _textRanking.text = ranking.ToString();
        _textScore.text = score.ToString();
        _textName.text = name;
    }
}
