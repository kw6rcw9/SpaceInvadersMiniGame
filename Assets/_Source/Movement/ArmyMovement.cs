
using System.Collections.Generic;

using UnityEngine;

namespace Movement
{
    public class ArmyMovement: IMovable
    {
        private Vector3 _endPos;
        private GameObject _parent;
        
        public ArmyMovement(GameObject parent)
        { 
            _parent = parent;

        }

        public void Move(  float distanceY,  float speed, List<Transform> enemies)
        {
            Vector3 position = _parent.transform.position;
            _endPos = position + new Vector3(0,distanceY,0);
            SetParent(enemies);
            position = Vector3.MoveTowards(position, 
                _endPos, speed* Time.deltaTime);
            _parent.transform.position = position;
        }
        private void SetParent(List<Transform> enemies)
        {
            foreach (Transform enemy in enemies)
            {
                /*if (enemy == null )
                    enemies.Remove(enemy);*/
                if (enemy == null) continue;
                if (enemy.parent != _parent.transform)
                    enemy.SetParent(_parent.transform);


            }

        }
       

    }
    
}
