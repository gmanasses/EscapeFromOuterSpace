using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using UnityEngine;

public class RankingController : MonoBehaviour {

    // --- Private Declarations ---
    [SerializeField] private List<Ranked> _rankedList;
    private static string FILENAME = "ranking.json";
    private static string _pathToFile;


    // --- Core Functions ---
    private void Awake() {
         _pathToFile = Path.Combine(Application.persistentDataPath, FILENAME);

        if(File.Exists(_pathToFile)) {
            string jsonText = File.ReadAllText(_pathToFile);
            JsonUtility.FromJsonOverwrite(jsonText, this);

        } else {
            _rankedList = new List<Ranked>();
        }
    }


    // --- Functions ---
    public ReadOnlyCollection<Ranked> GetRankeds() {
        return _rankedList.AsReadOnly();
    }

    public int AddScoreToList(string name, int score) {
        int id = _rankedList.Count;
        Ranked newRanked = new Ranked(id, name, score);

        _rankedList.Add(newRanked);
        _rankedList.Sort();
        SaveRanking();

        return id;
    }

    public void ChangeName(int id, string newName) {
        foreach(Ranked ranked in _rankedList) {
            if(ranked.Id == id) {
                ranked.Name = newName;
                break;
            }
        }

        SaveRanking();
    }

    private void SaveRanking() {
        string jsonText = JsonUtility.ToJson(this);
        File.WriteAllText(_pathToFile, jsonText);
    }
}


[Serializable]
public class Ranked : IComparable {

    // --- Public Declarations ---
    public int Id;
    public int Score;
    public string Name;


    // --- Functions ---
    public Ranked(int id, string name, int score) {
        Id = id;
        Name = name;
        Score = score;
    }

    public int CompareTo(object obj) {
        var otherObj = obj as Ranked;
        return otherObj.Score.CompareTo(this.Score);
    }
}
