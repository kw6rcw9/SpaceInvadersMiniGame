using ScoreSystem;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameSystem
{
    public class RestartGame : MonoBehaviour
    {
        private Game _game;
        void Start()
        {
            _game = new Game();
        }

        public void Restart()
        {
            _game.Restart();
        }
    }
}
