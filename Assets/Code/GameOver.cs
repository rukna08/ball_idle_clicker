using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    public AudioClip game_over_sfx;
    public GameObject high_score;
    GameObject ball;

    private void OnCollisionEnter2D(Collision2D collision) {
        ball = GameObject.Find("Ball");
        ball.GetComponent<SpriteRenderer>().enabled = false;
        AudioSource.PlayClipAtPoint(game_over_sfx, transform.position);
        PlayerPrefs.SetInt("HighScoreCount", high_score.GetComponent<HighScore>().high_score_count);
        PlayerPrefs.Save();
        Camera.main.backgroundColor = Color.red;
        StartCoroutine(WaitForAudioToEnd());
    }

    IEnumerator WaitForAudioToEnd() {
        yield return new WaitForSeconds(game_over_sfx.length);
        SceneManager.LoadScene("GameScene");
    }
}