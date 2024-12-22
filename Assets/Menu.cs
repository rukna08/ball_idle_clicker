using UnityEngine;

public class Menu : MonoBehaviour {
    
    public GameManager game_manager;
    
    bool is_menu_open = false;
    
    GameObject menu_gfx;
    GameObject paused_gfx;
    GameObject unpaused_gfx;

    void Start() {
        menu_gfx = GameObject.Find("MenuGFX");
        paused_gfx = menu_gfx.transform.GetChild(0).gameObject;
        unpaused_gfx = menu_gfx.transform.GetChild(1).gameObject;
    }

    public void PauseAndUnpause() {
        if(is_menu_open) {
            game_manager.UnpauseGame();
            paused_gfx.SetActive(true);
            unpaused_gfx.SetActive(false);
        } else if(!is_menu_open) {
            game_manager.PauseGame();
            paused_gfx.SetActive(false);
            unpaused_gfx.SetActive(true);
        }
        is_menu_open = !is_menu_open;
    }
}
