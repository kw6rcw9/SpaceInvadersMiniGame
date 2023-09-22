using UnityEngine;

namespace GameSystem
{
    public class LosePanel : MonoBehaviour
    {
        [SerializeField] private GameObject losePanel;
      

        private void OnEnable()
        {
            Game.LoseAction += ShowPanel;
        }

        private void OnDisable()
        {
            Game.LoseAction -= ShowPanel;

        }

        private void ShowPanel()
        {
            losePanel.SetActive(true);
            
        }

    }
}
