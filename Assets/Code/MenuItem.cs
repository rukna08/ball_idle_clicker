using UnityEngine;

public class MenuItem : MonoBehaviour {
    
    public bool is_bought;
    public int price;
    public int score;
    // If the order of the Score Gameobject inside canvas changes then this
    // code won't work.
    Score score_script;

    void Start() {
        price = -1;
        score_script = GameObject.Find("Canvas").transform.GetChild(0).gameObject.GetComponent<Score>();
    }

    void Update() {
        score = score_script.score_count;
    }

    public void Buy() {
        if (!is_bought && price != -1) {
            if(score >= price) {
                is_bought = true;        
            }
        }
    }

    public void Select() {
        // Do the actual thing but has to be generic, for applying different things
        // like changing ball colors, score multipliers, background changes etc...
    }

}
