using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace Movement
{
    public class ArmyMovement: IMovable
    {
       

        public async Task Move( float distanceY, List<GameObject> enemies, float speed)
        {
            GameObject parent = new GameObject("parent");
            
            foreach (GameObject enemy in enemies)
                enemy.transform.SetParent(parent.transform);
            while (true)
            {
                parent.transform.Translate(new Vector3(0,distanceY,0) * speed * Time.deltaTime);
                await Task.Yield();
            }
            




        }



    }
}
