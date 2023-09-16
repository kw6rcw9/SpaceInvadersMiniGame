using System.Collections.Generic;
using System.Threading.Tasks;
using Movement;
using UnityEngine;

namespace PlayerSystem
{
    public class PlayerInvoker
    {
        private PlayerMovement _playerMovement;
        private Player _player;
        private PlayerCombat _playerCombat;
       

        public PlayerInvoker(Player player)
        {
            _playerMovement = new PlayerMovement();
            _playerCombat = new PlayerCombat();
            _player = player;
        }
        public async void Move(float inputX)
        {
            await _playerMovement.Move(inputX, _player.MovementSpeed, new List<Transform>(){_player.transform});
        }

        public void Shoot()
        {
            _playerCombat.Shoot(_player.FirePoint, _player.BulletPrefab);
        }
    }
}
