
using System.Collections.Generic;
using PlayerSystem;
using UnityEngine;

using Image = UnityEngine.UI.Image;

namespace UISystem
{
    public class HpView : MonoBehaviour
    {
        [SerializeField] private List<Image> images;
        private Queue<Image> _imagesQueue;
        private void Start()
        {
            _imagesQueue = new Queue<Image>();
            foreach (Image image in images)
            {
                _imagesQueue.Enqueue(image);
            }
        }

        private void OnEnable()
        {
            PlayerHit.DamageAction += GetHitShow;
        }

        private void OnDisable()
        {
            PlayerHit.DamageAction -= GetHitShow;
        }

        private void GetHitShow()
        {
            
            _imagesQueue.Dequeue().gameObject.SetActive(false);
        }
        
    }
}
