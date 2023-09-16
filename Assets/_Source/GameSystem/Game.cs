using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

namespace GameSystem
{
    public class Game
    {
        public void Lose()
        {
            Time.timeScale = 0f;

        }

        public void Restart()
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(0);

        }

        public void Win()
        {
            //TODO
        }
    
    }
}
