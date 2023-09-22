using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Movement;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

namespace EnemySystem
{
    public class EnemyArmyController : MonoBehaviour
    {
        [SerializeField] private bool isRandom;
        [SerializeField] private float armySpeed;
        [SerializeField] private List<Transform> spawnPoints;
        [SerializeField] private float generatePause;
        [SerializeField] private float distanceY;
        [SerializeField] private float movePause;
        [SerializeField]private List<Transform> enemiesList;
        [SerializeField] private GameObject parent;
        [SerializeField] private GameObject enemyPrefab;
        private EnemyArmyGenerator _enemyArmy;
        private IMovable _armyMovement;
        private Vector3 _startPos;

        private void Awake()
        {
            _enemyArmy = new EnemyArmyGenerator();
            _armyMovement = new ArmyMovement(parent);


        }

        private void Start()
        {
            StartCoroutine(ArmyGenerator());
            _startPos = parent.transform.position;

        }

        private void Update()
        {
            StartCoroutine(ArmyMove());
            RemoveNullObjects();
        }


        IEnumerator ArmyGenerator()
        {
            while (true)
            {
                yield return new WaitForSeconds(generatePause);
                enemiesList = _enemyArmy.ArmyGenerator( enemyPrefab, spawnPoints, isRandom);
   
            }
        }

        private IEnumerator ArmyMove()
        {
            float temp = 0;
            if (enemiesList.Count <= 0) yield break;
            if (parent.transform.position.y <= _startPos.y + distanceY)
            {
                temp = parent.transform.position.y;
                yield return new WaitForSeconds(movePause);
                _startPos.y = temp;
            }

            else if(parent.transform.position.y >= _startPos.y + distanceY)
            {
                _armyMovement.Move( distanceY,  armySpeed, enemiesList);
            }

        }

        private void RemoveNullObjects()
        {
            List<Transform> newEnemies = enemiesList.Where(x => x == null).ToList();
            enemiesList = enemiesList.Except(newEnemies).ToList();
        }
    }
}
