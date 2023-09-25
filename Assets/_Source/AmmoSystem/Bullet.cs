using System;
using System.Collections;
using System.Collections.Generic;
using EnemySystem;
using PlayerSystem;
using UnityEngine;

namespace AmmoSystem
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Bullet : MonoBehaviour
    {
        [field: SerializeField] public int Damage { get; private set; }
        [SerializeField] private float speed;
        [SerializeField] private Rigidbody2D rb;

        [SerializeField] private float destroyTime;
        public Action<Transform> ExplosionAction;
        private EnemyHit _hit;
        private const int _enemyLayer = 7;

        private void Awake()
        {
            _hit = new EnemyHit();
        }

        private void Update()
        {
            MoveForward();
            StartCoroutine(Lifetime());
        }

        private void MoveForward()
        {
            rb.AddForce(transform.up * speed * Time.deltaTime, ForceMode2D.Impulse);
            
        }

       

        private  void OnTriggerEnter2D(Collider2D col) 
        {
            
            if ( col.gameObject.layer == _enemyLayer)
            {
                _hit.TakeDamage(col.GetComponent<Enemy>(), Damage);
                ExplosionAction?.Invoke(gameObject.transform);
                Destroy(gameObject);
            }
            
        }

        

        IEnumerator Lifetime()
        {
            yield return new WaitForSeconds(destroyTime);
            Destroy(gameObject);
        }
    }
}
