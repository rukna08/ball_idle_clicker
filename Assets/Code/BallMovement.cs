using UnityEngine;

public class BallMovement : MonoBehaviour {
    Rigidbody2D rigid_body;
    float jump_speed;

    void Start() {
        rigid_body = GetComponent<Rigidbody2D>();
        jump_speed = 200f;
    }
    
    void Update() {
        if (Input.GetMouseButtonDown(0)) {
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