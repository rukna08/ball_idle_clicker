using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    public AudioClip game_over_sfx;

    private void OnCollisionEnter2D(Collision2D collision) {
        AudioSource.PlayClipAtPoint(game_over_sfx, transform.position);
        StartCoroutine(WaitForAudioToEnd());
    }

    IEnumerator WaitForAudioToEnd() {
        yield return new WaitForSeconds(game_over_sfx.length);
        SceneManager.LoadScene("GameScene");
    }
}