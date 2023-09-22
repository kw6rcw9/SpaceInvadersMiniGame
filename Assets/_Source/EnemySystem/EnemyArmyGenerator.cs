using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace EnemySystem
{
    public class EnemyArmyGenerator
    {
        private List<Transform> _enemies;

        public EnemyArmyGenerator()
        {
            _enemies = new List<Transform>();

        }
        public List<Transform> ArmyGenerator( GameObject enemyPrefab, List<Transform> spawnPoints, bool isRandom)
        {

            if (isRandom)
            {
                foreach (Transform point in spawnPoints)
                {
                    int rnd = Random.Range(0, 5);
                    if (rnd != 4 && rnd != 3 )
                    {
                        EnemyInit(enemyPrefab, point);
                        
                    }
                }
            }
            else
            {
                foreach (Transform point in spawnPoints)
                {
                    EnemyInit(enemyPrefab, point);
                }
            }
            return _enemies;
        }

        
        private void EnemyInit(GameObject enemyPrefab, Transform spawnPoint)
        {
             GameObject enemy = GameObject.Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation, spawnPoint);
             _enemies.Add(enemy.transform);
                
            
        }
        
    }
}
