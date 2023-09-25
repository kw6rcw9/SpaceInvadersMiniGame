
using System.Collections;

using PlayerSystem;
using UnityEngine;

namespace AmmoSystem
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class EnemyBullet : MonoBehaviour
    {
        [field: SerializeField] public int Damage { get; private set; }
        [SerializeField] private float speed;
        [SerializeField] private Rigidbody2D rb;
        [SerializeField] private Renderer selfRenderer;
        [SerializeField] private float destroyTime;
        private PlayerHit _playerHit;
        private const int _playerLayer = 6;

        private void Start()
        {
            _playerHit = new PlayerHit();
        }


        private void Update()
        {
            MoveForward();
            StartCoroutine(Lifetime());
        }

        private void MoveForward()
        {
            rb.AddForce(-transform.up * speed * Time.deltaTime, ForceMode2D.Impulse);
            
        }
        
        private  void OnTriggerEnter2D(Collider2D col) 
        {
            if ( col.gameObject.layer == _playerLayer)
            {
                _playerHit.TakeDamage(col.gameObject.GetComponent<Player>(), Damage);
                StartCoroutine(_playerHit.ChangeColor(col.transform));
               selfRenderer.enabled = false;
            }
            
        }

        IEnumerator Lifetime()
        {
            yield return new WaitForSeconds(destroyTime);
            Destroy(gameObject);
        }
    }
}
