using System.Collections;
using UnityEngine;

public class PauseControl : MonoBehaviour {

    // --- Private Declarations ---
    [SerializeField] private GameObject _pausePanel;
    [SerializeField, Range(0,1)] private float _timeScaleDuringPause;
    private bool _gameStopped;


    // --- Core Functions ---
    private void Update() {
        if(PlayerIsTouchingTheScreen()) {
            if(_gameStopped) {
                ContinueGame();
            }
        
        } else {
            if(!_gameStopped) {
                StopGame();
            }
        }
    }


    // --- Functions ---
    private bool PlayerIsTouchingTheScreen() {
        return (Input.touchCount > 0);        
    }

    private void ContinueGame() {
        StartCoroutine(WaitAndContinueGame());
    }

    private IEnumerator WaitAndContinueGame() {
        yield return new WaitForSecondsRealtime(0.2f);
        _pausePanel.SetActive(false);
        ChangeTimeScale(1f);
        _gameStopped = false;
    }

    private void StopGame() {        
        _pausePanel.SetActive(true);
        ChangeTimeScale(_timeScaleDuringPause);
        _gameStopped = true;
    }

    private void ChangeTimeScale(float scale) {
        Time.timeScale = scale;
        Time.fixedDeltaTime = 0.02f * Time.timeScale;
    }

}
