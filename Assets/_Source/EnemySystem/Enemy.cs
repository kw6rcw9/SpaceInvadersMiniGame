

using ScoreSystem;
using UnityEngine;


namespace EnemySystem
{
    public class Enemy : MonoBehaviour
    {
        [field: SerializeField] public int Hp { get;  set; }
        [field: SerializeField] public GameObject BulletPrefab { get; private set; }
        [field: SerializeField] public int ScorePointsForDeath { get; private set; }


        public void TakeDamage(int damage)
        {
            
            Hp -= damage;
            if (Hp <= 0)
            {
                Score.IncreaseScoreCount(ScorePointsForDeath);
                Destroy(gameObject);
                
            }
        }
    }
}
