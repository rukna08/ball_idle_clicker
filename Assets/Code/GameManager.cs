using UnityEngine;

public class GameManager : MonoBehaviour {
    
    public void PauseGame() {
        Time.timeScale = 0f;
    }

    public void UnpauseGame() {
        Time.timeScale = 1f;
    }

}
