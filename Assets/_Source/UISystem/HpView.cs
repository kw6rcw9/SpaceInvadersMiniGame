using System;
using System.Collections;
using System.Collections.Generic;
using PlayerSystem;
using UnityEngine;
using UnityEngine.UIElements;
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
            PlayerHit.DamageAction += GetHit;
        }

        private void OnDisable()
        {
            PlayerHit.DamageAction -= GetHit;
        }

        private void GetHit()
        {
            
            _imagesQueue.Dequeue().gameObject.SetActive(false);
        }
        
    }
}
