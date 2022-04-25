using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDrop : MonoBehaviour
{
    
    public GameObject goldDrop;
    public Enemy enemy;
    
    // Start is called before the first frame update
    void Start()
    {
        
        this.enemy = GetComponent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        if(enemy.health <= 0)
        {
           
                Instantiate(goldDrop, new Vector3(0, 0, 0), Quaternion.identity);
            
        }
    }
}
