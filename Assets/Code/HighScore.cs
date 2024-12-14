using TMPro;
using UnityEngine;

public class HighScore : MonoBehaviour {
    
    TMP_Text high_score_text;
    public GameObject score;
    Score score_script;
    public int high_score_count;

    void Start() {
        high_score_count = PlayerPrefs.GetInt("HighScoreCount", 0);
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
