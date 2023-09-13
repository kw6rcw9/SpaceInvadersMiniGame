using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AmmoSystem
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private int damage;
        [SerializeField] private float speed;
        [SerializeField] private Rigidbody2D rb;
     
        
        private void Update()
        {
            MoveForward();
            StartCoroutine(Lifetime());
        }

        private void MoveForward()
        {
            rb.AddForce(transform.up * speed * Time.deltaTime, ForceMode2D.Impulse);
            
        }

       

        private void OnCollisionEnter2D(Collision2D col)
        {
            if ( col.gameObject.layer == 7)
            {
                Destroy(gameObject);
            }
        }

        IEnumerator Lifetime()
        {
            yield return new WaitForSeconds(2f);
            Destroy(gameObject);
        }
    }
}
