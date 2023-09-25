
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using CombatSystem;
using GameSystem;
using Movement;

using UnityEngine;

using Random = UnityEngine.Random;

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
        [SerializeField] private int maxEnemies;
        [SerializeField] private int minShootingDelay;
        [SerializeField] private int maxShootingDelay;
        private EnemyArmyGenerator _enemyArmy;
        private IMovable _armyMovement;
        private Shooting _armyShooting;
        private Vector3 _startPos;
        private Game _game;
        
        private void Awake()
        {
            
            _enemyArmy = new EnemyArmyGenerator();
            _armyMovement = new ArmyMovement(parent);
            _armyShooting = new Shooting();
            _game = new Game();
        }

        private void Start()
        {
            StartCoroutine(ArmyGenerator());
            _startPos = parent.transform.position;
            StartCoroutine(ArmyShoot());

        }

        private void Update()
        {
            StartCoroutine(ArmyMove());
            EmptyArmyChecker();
            
        }
        
        IEnumerator ArmyGenerator()
        {
            while (enemiesList.Count < maxEnemies)
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

        private IEnumerator ArmyShoot()
        {
            yield return new WaitForSeconds(generatePause);
            while (enemiesList.Count != enemiesList.Where(x => x == null).ToList().Count)
            { 
                yield return new WaitForSeconds(Random.Range(minShootingDelay, maxShootingDelay));
                List<Transform> newEnemyList = enemiesList.Where(x => x != null).ToList();
                int index = Random.Range(0, newEnemyList.Count);
                if (newEnemyList.Count > 0)
                {
                    _armyShooting.Shoot(newEnemyList[index].GetChild(0), 
                        newEnemyList[index].GetComponent<Enemy>().BulletPrefab);
                    
                }

            }
            
        }

        private void EmptyArmyChecker()
        {
            if(enemiesList.Count == maxEnemies
               && enemiesList.Count == enemiesList.Where(x => x == null).ToList().Count
               && enemiesList.Count > 0)
                _game.Win();
                
        }

       
    }
}
