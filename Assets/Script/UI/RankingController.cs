using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class RankingController : MonoBehaviour {

    // --- Private Declarations ---
    [SerializeField] private List<int> _scores;
    private static string FILENAME = "ranking.json";
    private static string _pathToFile;


    // --- Core Functions ---
    private void Awake() {
         _pathToFile = Path.Combine(Application.persistentDataPath, FILENAME);
        string jsonText = File.ReadAllText(_pathToFile);

        JsonUtility.FromJsonOverwrite(jsonText, this);
    }


    // --- Functions ---
    public void AddScoreToList(int score) {
        _scores.Add(score);
        SaveRanking();
    }

    private void SaveRanking() {
        string jsonText = JsonUtility.ToJson(this);        
        File.WriteAllText(_pathToFile, jsonText);
    }

    public int NumberOfRankedInList() {
        return (_scores.Count);
    }

}
