using UnityEngine;

public class RankingPanel : MonoBehaviour {

    // --- Private Declarations ---
    [SerializeField] private RankingController _ranking;
    [SerializeField] private GameObject _prefabRanked;


    // --- Core Functions ---
    private void Start() {
        int amount = _ranking.NumberOfRankedInList();
        for(int i=0; i<amount; i++) {
            if(i > 5) { break; }
            GameObject ranked = GameObject.Instantiate(_prefabRanked, this.transform);
            ranked.GetComponent<RankedItem>().ConfigureText(i, 999, "teste");
        }
    }

}
