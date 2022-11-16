using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControls : MonoBehaviour
{
    public float speed;
    public float jumpAmount;
    public Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Jumping mechanic
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space was clicked");
            body.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
        }

        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");
        body.velocity = new Vector2(inputX * speed, inputY * speed);

    }
}
