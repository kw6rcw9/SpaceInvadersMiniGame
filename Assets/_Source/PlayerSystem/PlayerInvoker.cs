using System.Collections.Generic;

using CombatSystem;
using Movement;
using UnityEngine;

namespace PlayerSystem
{
    public class PlayerInvoker
    {
        private IMovable _playerMovement;
        private Player _player;
        private Shooting _playerCombat;
       

        public PlayerInvoker(Player player)
        {
            _playerMovement = new PlayerMovement();
            _playerCombat = new Shooting();
            _player = player;
        }
        public  void Move(float inputX)
        {
             _playerMovement.Move(inputX, _player.MovementSpeed, new List<Transform>(){_player.transform});
        }

        public void Shoot()
        {
            _playerCombat.Shoot(_player.FirePoint, _player.BulletPrefab);
        }

        
    }
}
