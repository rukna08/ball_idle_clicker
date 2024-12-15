using UnityEngine;
using UnityEngine.EventSystems;

public class BallMovement : MonoBehaviour {
    Rigidbody2D rigid_body;
    float jump_speed;

    void Start() {
        rigid_body = GetComponent<Rigidbody2D>();
        jump_speed = 200f;
    }
    
    void Update() {
        // EventSystem.current.IsPointerOverGameObject() checks
        // if the mouse pointer is over an UI element or not.
        if (!EventSystem.current.IsPointerOverGameObject() && Input.GetMouseButtonDown(0) && Time.timeScale == 1f) {
            rigid_body.AddForce(Vector2.up * jump_speed);        
            int direction = Random.Range(0, 2);
            if(direction == 0) { 
                rigid_body.AddForce(Vector2.left * 10f);
            } else if(direction == 1) {
                rigid_body.AddForce(Vector2.right * 10f);
            }
        }
    }
}