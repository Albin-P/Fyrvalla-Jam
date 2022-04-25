using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPlayer : MonoBehaviour
{

    public int EnemyDamange;
    private Collider2D c2D;

    [SerializeField]private float EnemyTimeBtwAttack;
    public float EnemyStartTimeBtwAttack;

    private bool canAttack;


    // Start is called before the first frame update
    void Start()
    {
        c2D = this.GetComponent<BoxCollider2D>();
        
    }

    private void Update()
    {
     
    }

    // Update is called once per frame
    void Attack(Collision2D collision)
    {

        if(EnemyTimeBtwAttack <= 0)
        {
            if (collision.collider.gameObject.tag == "Player")
            {
                Player player = collision.collider.gameObject.GetComponent<Player>();
                if (canAttack == true)
                {

                    player.hp -= EnemyDamange;
                    EnemyTimeBtwAttack = EnemyStartTimeBtwAttack;

                }
            }


        }
        if (EnemyTimeBtwAttack > 0)
        {
            canAttack = false;
        }
        else
        {
            EnemyTimeBtwAttack -= Time.deltaTime;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
            
            
            

            
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        
    }

}
