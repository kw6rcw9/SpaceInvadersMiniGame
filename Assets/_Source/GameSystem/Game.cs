using System;
using ScoreSystem;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameSystem
{
    public class Game
    {
        public static Action WinAction;
        public static Action LoseAction;
        public void Lose()
        {
            LoseAction?.Invoke();
            Time.timeScale = 0f;
        }
        
        public  void Win()
        {
            WinAction?.Invoke();
            Time.timeScale = 0f;
            
        }
        public void Restart()
        {
            Time.timeScale = 1f;
            Score.ResetScore();
            SceneManager.LoadScene(0);

        }
    
    }
}
