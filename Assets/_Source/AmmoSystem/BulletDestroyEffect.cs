
using UnityEngine;

namespace AmmoSystem
{
    public class BulletDestroyEffect : MonoBehaviour
    {
        [SerializeField] private GameObject effectPrefab;
        [SerializeField] private Bullet bullet;

        private void OnEnable()
        {
            bullet.ExplosionAction += Explosion;
        }

        private void OnDisable()
        {
            bullet.ExplosionAction -= Explosion;
        }

        void Explosion(Transform bulletPos)
        {
            GameObject exp = Instantiate(effectPrefab, bulletPos.position, bulletPos.rotation);
            Destroy(exp, 0.75f);
        }

    }
}
