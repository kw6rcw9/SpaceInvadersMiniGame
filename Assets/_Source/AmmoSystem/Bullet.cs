using UnityEngine;

namespace AmmoSystem
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float speed;
        private Rigidbody2D _rb;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            MoveForward();
        }

        private void MoveForward()
        {
            _rb.AddForce(transform.up * speed * Time.deltaTime, ForceMode2D.Impulse);
            
        }

        private void OnCollisionEnter(Collision collision)
        {
            if(collision.gameObject.layer != 6)
                Destroy(gameObject);
        }
    }
}
