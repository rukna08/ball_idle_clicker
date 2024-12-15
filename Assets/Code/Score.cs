using UnityEngine;
using TMPro;

public class Score : MonoBehaviour {

    TMP_Text score_text;
    public int score_count;

    void Start() {
        score_count = 0;
        score_text = GetComponent<TMP_Text>();
    }

    void Update() {
        if(Input.GetMouseButtonDown(0) && Time.timeScale == 1f) {
            score_count++;
            score_text.text = score_count.ToString();
        }
    }
}
