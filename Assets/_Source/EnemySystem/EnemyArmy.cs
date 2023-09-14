using System.Collections.Generic;
using UnityEngine;

namespace EnemySystem
{
    public class EnemyArmy
    {
        public  void ArmyLogic(List<GameObject> list, float speed, GameObject enemyPrefab, Transform spawnPoint)
        {
            
            
        }

        private void EnemyInit(List<GameObject> enemyPrefabs, Transform spawnPoint)
        {
            foreach (GameObject enemyPref in enemyPrefabs)
            {
                GameObject enemy = GameObject.Instantiate(enemyPref, spawnPoint);
                
            }
        }
    }
}
