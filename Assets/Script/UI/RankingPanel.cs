using System.Collections.ObjectModel;
using UnityEngine;

public class RankingPanel : MonoBehaviour {

    // --- Private Declarations ---
    [SerializeField] private RankingController _ranking;
    [SerializeField] private GameObject _prefabRanked;


    // --- Core Functions ---
    private void Start() {
        ReadOnlyCollection<Ranked> listOfRankeds = _ranking.GetRankeds();

        for(int i=0; i<listOfRankeds.Count; i++) {
            if(i > 5) { break; }

            GameObject ranked = GameObject.Instantiate(_prefabRanked, this.transform);
            ranked.GetComponent<RankedItem>().ConfigureText(i, listOfRankeds[i].Score, listOfRankeds[i].Name);
        }
    }
}
