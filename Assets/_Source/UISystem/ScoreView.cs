using System;
using ScoreSystem;
using TMPro;
using UnityEngine;

namespace UISystem
{
    public class ScoreView : MonoBehaviour
    {
        [SerializeField] private TMP_Text text;

        private void OnEnable()
        {
            Score.ScoreChangeAction += ScoreRefresh;
        }

        private void OnDisable()
        {
            Score.ScoreChangeAction -= ScoreRefresh;
        }

        private void ScoreRefresh(int score)
        {
            text.text = "Score: " + score;
        }
    }
}
