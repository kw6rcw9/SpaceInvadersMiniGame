using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace EnemySystem
{
    public class EnemyArmy
    {
        private bool _isGenerated = false;
        private List<GameObject> _enemies = new List<GameObject>();

        public  void ArmyGenerator(float speed, GameObject enemyPrefab, List<Transform> spawnPoints, bool isRandom)
        {
            
            
            if (isRandom)
            {
                foreach (Transform point in spawnPoints)
                {
                    int rnd = Random.Range(0, 2);
                    if (rnd == 1)
                        EnemyInit(enemyPrefab, point);
                }

                _isGenerated = true;
            }

            else
            {
                foreach (Transform point in spawnPoints)
                {
                    EnemyInit(enemyPrefab, point);
                }
                _isGenerated = true;
                
            }
            

        }

        private void EnemyInit(GameObject enemyPrefab, Transform spawnPoint)
        {
             GameObject enemy = GameObject.Instantiate(enemyPrefab, spawnPoint);
             _enemies.Add(enemy);
                
            
        }

        private void ArmyMove(Transform controller)
        {
            
        }
    }
}
