using System;
using PlayerSystem;
using UnityEngine;

namespace InputSystem
{
    public class InputListener : MonoBehaviour
    {
        [SerializeField] private Player player;
        private PlayerInvoker _playerInvoker;

        private void Awake()
        {
            _playerInvoker = new PlayerInvoker(player);
        }

        void Update()
        {
            ReadMove();
            ReadShoot();
        }

        private void ReadMove()
        {
            float x = Input.GetAxis("Horizontal");
            _playerInvoker.Move(x);
            
        }

        private void ReadShoot()
        {
            if(Input.GetMouseButtonDown(0))
                _playerInvoker.Shoot();
        }
        
    }
}
