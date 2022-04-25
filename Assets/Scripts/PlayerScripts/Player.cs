using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
     public int hp;

    [SerializeField]
    public int Playergold = 0;

    [SerializeField]
    public int damage = 0;

    private void Start()
    {
        hp = 100;
        damage = 10;

    }


}
