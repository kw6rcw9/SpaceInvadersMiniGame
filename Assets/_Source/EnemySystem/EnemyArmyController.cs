using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Movement;
using UnityEngine;

namespace EnemySystem
{
    public class EnemyArmyController : MonoBehaviour
    {
        [SerializeField] private bool isRandom;
        [SerializeField] private float armySpeed;
        [SerializeField] private List<Transform> spawnPoints;
        [SerializeField] private GameObject enemyPrefab;
        [SerializeField] private float time;
        [SerializeField] private float distanceY;
        private EnemyArmyGenerator _enemyArmy;
        private ArmyMovement _armyMovement;

      
        private List<GameObject> _enemiesList;
        //private bool _inGame = true;
        private void Awake()
        {
            _enemyArmy = new EnemyArmyGenerator();
            _armyMovement = new ArmyMovement();
        }

        private void Start()
        {
            StartCoroutine(ArmyGenerator());
        }

      

        IEnumerator ArmyGenerator()
        {
            while (true)
            {
                
                yield return new WaitForSeconds(time);
                _enemiesList = _enemyArmy.ArmyGenerator( enemyPrefab, spawnPoints, isRandom);
               
                ArmyMove(_enemiesList);
                //Destroy(_armyMovement.Controller);
               
            }
          
        }

        private async void ArmyMove(List<GameObject> enemies)
        {
            //if(_isGenerated)
            await _armyMovement.Move(distanceY, enemies, armySpeed);




        }
        
        
    }
}
