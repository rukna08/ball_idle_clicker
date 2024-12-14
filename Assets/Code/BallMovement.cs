using UnityEngine;

public class BallMovement : MonoBehaviour {
    Rigidbody2D rigidbody;
    float jump_speed;

    void Start() {
        rigidbody = GetComponent<Rigidbody2D>();
        jump_speed = 200f;
    }
    
    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            rigidbody.AddForce(Vector2.up * jump_speed);            
            int direction = Random.Range(0, 2);
            if(direction == 0) { 
                rigidbody.AddForce(Vector2.left * 10f);
            } else if(direction == 1) {
                rigidbody.AddForce(Vector2.right * 10f);
            }
        }
    }
}