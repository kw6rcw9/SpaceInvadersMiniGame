using System;
using AmmoSystem;
using UnityEngine;
using UnityEngine.Serialization;

namespace EnemySystem
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private int hp;
        [SerializeField] private Bullet bullet;

        private void OnTriggerEnter2D(Collider2D col)
        {
            TakeDamage(bullet.Damage);
        }

        private void TakeDamage(int damage)
        {
            
            hp -= damage;
            if(hp <= 0)
                Destroy(gameObject);
        }
    }
}
