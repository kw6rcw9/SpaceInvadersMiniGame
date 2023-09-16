using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace Movement
{
    public class PlayerMovement: IMovable
    {
        private const float _borderX = 8.33f;
        public async Task Move(float inputX, float speed, List<Transform> transform)
        {
            if(transform[0].position.x < _borderX * -1 && inputX < 0 || transform[0].position.x > _borderX && inputX > 0 ) 
                transform[0].Translate(new Vector3(0, 0, 0));
            else
                transform[0].Translate(new Vector3(inputX * speed * Time.deltaTime, 0, 0));
            await Task.Yield();
        }
    }
}
