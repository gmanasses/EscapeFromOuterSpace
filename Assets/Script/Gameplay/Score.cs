using System;
using UnityEngine;
using UnityEngine.Events;

public class Score : MonoBehaviour {

    // --- Public Declarations ---
    public int TotalScore { get { return _score; } }

    // --- Private Declarations ---
    [SerializeField] CustomEventInt _whenScores;
    private int _score;


    // --- Functions ---
    private void Start() {
        GameObject.DontDestroyOnLoad(this.gameObject);
    }


    // --- Functions ---
    public void AddScore() {
        _score++;
        _whenScores.Invoke(_score);
    }

}


[Serializable]
public class CustomEventInt : UnityEvent<int> { }