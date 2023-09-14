using System;
using AmmoSystem;
using UnityEngine;

namespace EnemySystem
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private int hp;
        
        /*private void TakeDamage(int damage)
        {
            Debug.Log("dd");
            if(hp <= 0)
                Destroy(gameObject);
            hp -= damage;
        }*/
    }
}
