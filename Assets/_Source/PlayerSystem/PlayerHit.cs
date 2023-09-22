using System.Collections;
using GameSystem;
using UnityEngine;

namespace PlayerSystem
{
    public class PlayerHit
    {
        private Game _game;
        public PlayerHit()
        {
            _game = new Game();
        }
        
        public void TakeDamage(Player player, int damage)
        {
            
           player.Hp -= damage;
            if (player.Hp <= 0)
            {
                _game.Lose();

            }
        }

        public IEnumerator ChangeColor(Transform player)
        {
            Color temp = player.GetComponent<Renderer>().material.color;
            player.GetComponent<Renderer>().material.color = Color.red;
            yield return new WaitForSeconds(0.1f);
            player.GetComponent<Renderer>().material.color = temp;
        }
    }
}
