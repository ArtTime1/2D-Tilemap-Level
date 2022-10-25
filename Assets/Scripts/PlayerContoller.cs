using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rigidbody;
    Vector2 movement;
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        InputHandler();
    }

    private void FixedUpdate()
    {
        MovementHandler();
    }

    public void MovementHandler()
    {
        rigidbody.MovePosition(rigidbody.position + movement.normalized * speed * Time.fixedDeltaTime);
    }
    public void InputHandler()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        movement = new Vector2(horizontal, vertical);
    }
}
