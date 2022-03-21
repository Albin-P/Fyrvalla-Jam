using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldDrop : MonoBehaviour
{
    public Enemy enemy;
    public GameObject goldPrefab;
    // Start is called before the first frame update
    void Start()
    {
        this.enemy = GetComponent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
       if(enemy.getEnemyHealth() <= 0)
       {
            Instantiate(goldPrefab, transform.position, transform.rotation);
        }
    }
}
