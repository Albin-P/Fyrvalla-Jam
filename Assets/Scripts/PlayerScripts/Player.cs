using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int hp;

    [SerializeField]
    private int score = 0;

    [SerializeField]
    private int damage = 0;

    public Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        hp = 100;
        damage = 10;
        score = 0;

    }

    public int GetPlayerDamage()
    {
        return damage;
    }
    public int GetPlayerHp()
    {
        return hp;
    }

    public void SetPlayerHp(int val)
    {
        this.hp = val;
    }
}
