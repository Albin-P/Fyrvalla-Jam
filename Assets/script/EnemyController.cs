using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyController : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private GameObject player;
    [SerializeField] private float speed = 1.5f;
    bool inRad = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()

        
    {
        if(inRad == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
        
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        inRad = true;
        Debug.Log("in range");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        inRad = false;
    }
}
