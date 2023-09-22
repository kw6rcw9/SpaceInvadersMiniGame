using UnityEngine;

namespace GameSystem
{
    public class WinPanel : MonoBehaviour
    {
        [SerializeField] private GameObject winPanel;
      

        private void OnEnable()
        {
            Game.WinAction += ShowPanel;
        }

        private void OnDisable()
        {
           Game.WinAction -= ShowPanel;

        }

        private void ShowPanel()
        {
            winPanel.SetActive(true);
            
        }
    
    }
}
