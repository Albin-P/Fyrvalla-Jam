using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPlayer : MonoBehaviour
{

    public int EnemyDamange;
    private Collider2D c2D;
    
    
    // Start is called before the first frame update
    void Start()
    {
        c2D = this.GetComponent<BoxCollider2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag == "Player")
        {
            Player player = collision.collider.gameObject.GetComponent<Player>();
            player.hp -= EnemyDamange; 
        }
        Debug.Log("hit");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        
    }

}
