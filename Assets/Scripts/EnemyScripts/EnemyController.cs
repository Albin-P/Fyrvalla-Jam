using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyController : MonoBehaviour
{
    private Rigidbody2D rb;

    public Transform player;
    public float moveSpeed;
    private Vector2 movement;
    bool inRad = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
            Vector3 direction = player.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            rb.rotation = angle;

            movement = direction.normalized;

    }

    private void FixedUpdate()
    {
        if (inRad == true)
        {
            moveEnemy(movement);
        }
        
    }

    void moveEnemy(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }

    private void OnTriggerStay2D(Collider2D collission)
    {

        if (collission.tag == "Player")
        {
            inRad = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            inRad = false;
        }
    }

}
