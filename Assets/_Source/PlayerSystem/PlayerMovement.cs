using UnityEngine;

namespace PlayerSystem
{
    public class PlayerMovement
    {
        private const float _borderX = 8.33f;
        public void Move(float inputX, float speed, Transform transform)
        {
            if(transform.position.x < _borderX * -1 && inputX < 0 || transform.position.x > _borderX && inputX > 0 ) 
                transform.Translate(new Vector3(0, 0, 0));
            else
                transform.Translate(new Vector3(inputX * speed * Time.deltaTime, 0, 0));
        }
    }
}
