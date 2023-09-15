using System.Collections.Generic;
using UnityEngine;

namespace EnemySystem
{
    public interface IArmyLogic
    {
        List<GameObject> ArmyGenerator(GameObject enemyPrefab, List<Transform> spawnPoints, bool isRandom);
        void ArmyMove( List<GameObject> enemies, float speed);



    }
}
