using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AmmoSystem
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Bullet : MonoBehaviour
    {
        [field: SerializeField] public int Damage { get; private set; }
        [SerializeField] private float speed;
        [SerializeField] private Rigidbody2D rb;
        //[SerializeField] private LayerMask enemyMask;


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
            //if ( col.gameObject.layer == enemyMask)
            //{
                
                Debug.Log("collide");
                Destroy(gameObject);
           // }
            
        }

        IEnumerator Lifetime()
        {
            yield return new WaitForSeconds(2f);
            Destroy(gameObject);
        }
    }
}
