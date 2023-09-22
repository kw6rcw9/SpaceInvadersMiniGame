using System;
using AmmoSystem;
using ScoreSystem;
using UnityEngine;
using UnityEngine.Serialization;

namespace EnemySystem
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private int hp;
        [field: SerializeField] public GameObject BulletPrefab { get; private set; }
        [SerializeField] private int scorePointsForDeath;

       

        public void TakeDamage(int damage)
        {
            
            hp -= damage;
            if (hp <= 0)
            {
                Score.IncreaseScoreCount(scorePointsForDeath);
                Destroy(gameObject);
                
            }
        }
    }
}
