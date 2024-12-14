using UnityEngine;

public class Audio : MonoBehaviour {

    public AudioClip click_sfx;
    public AudioClip background_sfx;

    void Start() {
        AudioSource.PlayClipAtPoint(background_sfx, transform.position);
        GameObject background_one_shot_audio = GameObject.Find("One shot audio");
        background_one_shot_audio.GetComponent<AudioSource>().loop = true;
    }

    void Update() {
        if(Input.GetMouseButtonDown(0)) {
            AudioSource.PlayClipAtPoint(click_sfx, transform.position);
        }
    }
}
