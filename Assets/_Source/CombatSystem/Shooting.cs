using UnityEngine;

namespace CombatSystem
{
    public class Shooting
    {
        

        public void Shoot(Transform firePoint, GameObject bulletPrefab)
        {
            GameObject bullet = GameObject.Instantiate(bulletPrefab, firePoint.position, firePoint.rotation, firePoint);
        }
        

    }
}
