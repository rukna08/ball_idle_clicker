using UnityEngine;

public class Menu : MonoBehaviour {
    
    public GameManager gameManager;
    
    bool is_menu_open = false;

    public void PauseAndUnpause() {
        if(is_menu_open) {
            gameManager.UnpauseGame();
        } else if(!is_menu_open) {
           gameManager.PauseGame();
        }
        is_menu_open = !is_menu_open;
    }
}
