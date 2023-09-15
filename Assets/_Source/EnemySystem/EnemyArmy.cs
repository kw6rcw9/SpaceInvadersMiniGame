using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace EnemySystem
{
    public class EnemyArmy: IArmyLogic
    {
        //private bool _isGenerated = false;
        private List<GameObject> _enemies;
        //private GameObject _parent = new ;
       

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
                
                //_isGenerated = true;
            }

            else
            {
                foreach (Transform point in spawnPoints)
                {
                    //EnemyInit(enemyPrefab, point);
                }
               // _isGenerated = true;
                
            }

            return _enemies;
        }

        
        private void EnemyInit(GameObject enemyPrefab, Transform spawnPoint)
        {
             GameObject enemy = GameObject.Instantiate(enemyPrefab, spawnPoint);
             _enemies.Add(enemy);
                
            
        }

        public void ArmyMove( List<GameObject> enemies, float speed)
        {
            GameObject controller = new GameObject("parent");
            foreach (GameObject enemy in enemies)
                enemy.transform.SetParent(controller.transform);
            controller.transform.Translate(Vector3.down * speed * Time.deltaTime);
            
            
            
            
        }
    }
}
