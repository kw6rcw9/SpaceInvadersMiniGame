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
        private EnemyArmy _enemyArmy;
        private bool _inGame = true;
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
            
        }

        IEnumerator ArmyGenerator()
        {
            while (true)
            {
                yield return new WaitForSeconds(time);
                _enemyArmy.ArmyGenerator(armySpeed, enemyPrefab, spawnPoints, isRandom);
                
            }
          
        }
    }
}
