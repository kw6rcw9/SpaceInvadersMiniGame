using System;
using System.Threading.Tasks;
using GameSystem;
using PlayerSystem;
using UnityEngine;

namespace InputSystem
{
    public class InputListener : MonoBehaviour
    {
        [SerializeField] private Player player;
        private PlayerInvoker _playerInvoker;
        private Game _game;

        private void Awake()
        {
            _playerInvoker = new PlayerInvoker(player);
            _game = new Game();
        }

        void Update()
        {
            ReadMove();
            ReadShoot();
            ReadGameState();
        }

        private  void ReadMove()
        {
            float x = Input.GetAxis("Horizontal");
             _playerInvoker.Move(x);
            
        }

        private void ReadShoot()
        {
            if(Input.GetMouseButtonDown(0))
                _playerInvoker.Shoot();
        }

        private void ReadGameState()
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                _game.Restart();
            }
        }
        
    }
}
