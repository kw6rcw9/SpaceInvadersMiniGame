using ScoreSystem;
using UnityEngine;

namespace EnemySystem
{
    public class EnemyHit
    {
        public void TakeDamage(Enemy enemy, int damage)
        {
            
            enemy.Hp -= damage;
            if (enemy.Hp <= 0)
            {
                Score.IncreaseScoreCount(enemy.ScorePointsForDeath);
                Object.Destroy(enemy.gameObject);

            }
        }
       
    }
}
