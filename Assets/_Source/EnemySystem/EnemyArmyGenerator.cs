using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace EnemySystem
{
    public class EnemyArmyGenerator
    {
     
        private List<GameObject> _enemies;
     
       

        public List<GameObject> ArmyGenerator( GameObject enemyPrefab, List<Transform> spawnPoints, bool isRandom)
        {

            _enemies = new List<GameObject>();

            
            if (isRandom)
            {
                foreach (Transform point in spawnPoints)
                {
                    int rnd = Random.Range(0, 2);
                    if (rnd == 1)
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
             GameObject enemy = GameObject.Instantiate(enemyPrefab, spawnPoint);
             _enemies.Add(enemy);
                
            
        }
        
    }
}
