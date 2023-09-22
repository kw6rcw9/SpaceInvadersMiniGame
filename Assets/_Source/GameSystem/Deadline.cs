using UnityEngine;

namespace GameSystem
{
   public class Deadline : MonoBehaviour
   {
      private Game _game;
      private void Awake()
      {
         _game = new Game();
      }

      private void OnTriggerEnter2D(Collider2D col)
      {
      
         if (col.gameObject.layer != 6 && col.gameObject.layer != 8 )
         {
            _game.Lose();
         }
      }
   }
}
