using TMPro;
using UnityEngine;

public class HighScore : MonoBehaviour {
    
    TMP_Text high_score_text;
    public GameObject score;
    Score score_script;
    int high_score_count;

    void Start() {
        // load high_score_count thru serialisation
        // right now setting to 10
        high_score_count = 10;
        high_score_text = GetComponent<TMP_Text>();
        score_script = score.GetComponent<Score>();
    }

    void Update() {
        if(score_script.score_count >= high_score_count) {
            high_score_count = score_script.score_count;    
        }
        high_score_text.text = high_score_count.ToString();
    }

}
