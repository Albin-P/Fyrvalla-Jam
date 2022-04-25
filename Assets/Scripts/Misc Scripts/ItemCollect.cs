using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollect : MonoBehaviour
{

    public Enemy enemy;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Player>();
        this.GetComponent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.tag == "Player")
        {
            
        }
    }
}
