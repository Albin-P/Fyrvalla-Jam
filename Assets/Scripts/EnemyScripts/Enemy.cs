using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{


    public int health;
    [SerializeField] public int gold;


    // Start is called before the first frame update
    void Start()
    {
        gold = 50;
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
}
