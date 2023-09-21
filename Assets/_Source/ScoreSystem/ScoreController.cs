using GameSystem;
using UnityEngine;

namespace ScoreSystem
{
    public class ScoreController : MonoBehaviour
    {
        [SerializeField] private int maxScore;
        private Game _game;
        void Start()
        {
            _game = new Game();
        }
        
        void Update()
        {
            ScoreChecker();
        
        }

        private void ScoreChecker()
        {
            if(Score.ScoreCount == maxScore)
                _game.Win();
        }
    }
}
