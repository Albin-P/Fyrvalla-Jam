using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyVar", menuName = "Enemy/EnemyVar")]
public class EnemySO : ScriptableObject
{
    public int health;
    public int gold;
    public int damage;

    public Color color;


}
