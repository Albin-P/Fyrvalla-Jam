using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemySO enemyVar;

    private int health;
    private int damage;
    private Color color;
    [SerializeField] public int gold;


    // Start is called before the first frame update
    void Start()
    {
        gold = enemyVar.gold;
        damage = enemyVar.damage;
        health = enemyVar.health;
        color = enemyVar.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void takeDamage(int damage)
    {
        health -= damage;
        Debug.Log("damage taken");
    }

    public int getEnemyHealth()
    {
        return health;
    }

    public int getEnemyDamage()
    {
        return damage;
    }

}
