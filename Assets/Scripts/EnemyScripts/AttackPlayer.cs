using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPlayer : MonoBehaviour
{

    
    private Collider2D c2D;
    private Enemy enemy;
    public float push;
   

    // Start is called before the first frame update
    void Start()
    {
        c2D = this.GetComponent<BoxCollider2D>();
        enemy = GetComponent<Enemy>();
    }

    private void Update()
    {
     
    }

    // Update is called once per frame
    void Attack(Collision2D collision)
    {

        
        
           


        
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.collider.gameObject.tag == "Player")
        {
            Player player = collision.collider.gameObject.GetComponent<Player>();


            player.SetPlayerHp(player.GetPlayerHp() - enemy.enemyVar.damage);

            Rigidbody2D rb = GetComponent<Rigidbody2D>();

            

        }


    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        
    }

}
