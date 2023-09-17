using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace Movement
{
    public class PlayerMovement: IMovable
    {
        private const float _borderX = 8.33f;
        public void Move(float inputX, float speed, List<Transform> transform) 
        {
            if (transform[0].position.x < _borderX * -1 && inputX < 0 ||
                transform[0].position.x > _borderX && inputX > 0)
                transform[0].Translate(new Vector3(0, 0, 0));
            else
                transform[0].Translate(new Vector3(inputX * speed * Time.deltaTime, 0, 0));

        }

        public void Move<T>(float dist, float speed, List<T> objects) where T : Transform
        {
            throw new System.NotImplementedException();
        }
    }
}
