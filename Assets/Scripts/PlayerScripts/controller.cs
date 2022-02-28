using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    public float moveSpeed = 5f;
    //public int Health;
    public Player player;

    public Rigidbody2D rb;

    private void Start()
    {
        this.player = GetComponent<Player>();
        this.rb = GetComponent<Rigidbody2D>();
    }

    Vector2 movement;
    // Update is called once per frame
    void Update()
    {
        // input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        Vector2 playerPosition = transform.position;
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePosition - playerPosition;
        transform.up = direction;

        // health
        if(player.hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        // movment
        rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.fixedDeltaTime);
        
    }

    
}
