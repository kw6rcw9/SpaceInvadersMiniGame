using System;
using System.Collections;
using System.Collections.Generic;
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
        private IArmyLogic _enemyArmy;
        private bool _isGenerated = false;

        private List<GameObject> _enemiesList;
        //private bool _inGame = true;
        private void Awake()
        {
            _enemyArmy = new EnemyArmy();
        }

        private void Start()
        {
            StartCoroutine(ArmyGenerator());
        }

        private void Update()
        {
            ArmyMove(_enemiesList);
        }

        IEnumerator ArmyGenerator()
        {
            while (true)
            {
                yield return new WaitForSeconds(time);
                _enemiesList = _enemyArmy.ArmyGenerator( enemyPrefab, spawnPoints, isRandom);
                _isGenerated = true;

            }
          
        }

        private void ArmyMove(List<GameObject> enemies)
        {
            if (_isGenerated)
            {
                _enemyArmy.ArmyMove(enemies, armySpeed);
                
            }
            
        }
        
        
    }
}
