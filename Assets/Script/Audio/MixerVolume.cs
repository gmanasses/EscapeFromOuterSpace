using UnityEngine;
using UnityEngine.Audio;

public class MixerVolume : MonoBehaviour {

    // --- Private Declarations ---
    [SerializeField] private AudioMixer _mixer;
    [SerializeField] private string _mixerParam;


    // --- Core Functions ---
    private void Start() {
        if (PlayerPrefs.HasKey(_mixerParam)) {
            _mixer.SetFloat(_mixerParam, PlayerPrefs.GetFloat(_mixerParam));

        } else {
            _mixer.SetFloat(_mixerParam, 0);
        }
    }


    // --- Functions ---
    public void ChangeVolume(float volume) {
        _mixer.SetFloat(_mixerParam, volume);
        PlayerPrefs.SetFloat(_mixerParam, volume);
    }

}
