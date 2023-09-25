
using UnityEngine;


namespace GameSystem
{
    public class RestartGame : MonoBehaviour
    {
        private Game _game;
        private void Awake()
        {
            Time.timeScale = 1;
            _game = new Game();
        }

        public void Restart()
        {
            _game.Restart();
            
        }
    }
}
