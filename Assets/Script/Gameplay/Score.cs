using System;
using UnityEngine;
using UnityEngine.Events;

public class Score : MonoBehaviour {

    // --- Private Declarations ---
    [SerializeField] CustomEventInt _whenScores;
    private int _score;


    // --- Functions ---
    public void AddScore() {
        _score++;
        _whenScores.Invoke(_score);
    }

}

[Serializable]
public class CustomEventInt : UnityEvent<int> {

}