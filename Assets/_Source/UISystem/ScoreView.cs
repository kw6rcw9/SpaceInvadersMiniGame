
using ScoreSystem;
using TMPro;
using UnityEngine;

namespace UISystem
{
    public class ScoreView : MonoBehaviour
    {
        [SerializeField] private TMP_Text text;
        private string _origText;
        private void Awake()
        {
            _origText = text.text;
            text.text += 0;
        }

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
            text.text = _origText + score;
        }
    }
}
