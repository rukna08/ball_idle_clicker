using UnityEngine;

public class GameManager : MonoBehaviour {
    
    public void PauseGame() {
        Debug.Log("Game Paused!");
        Time.timeScale = 0f;
    }

    public void UnpauseGame() {
        Debug.Log("Game Unpaused!");
        Time.timeScale = 1f;
    }

}
