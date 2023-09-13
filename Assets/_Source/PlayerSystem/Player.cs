using UnityEngine;

namespace PlayerSystem
{
    public class Player : MonoBehaviour
    {
        [field: SerializeField] public float MovementSpeed { get; private set; }
        //[field: SerializeField] public float ShootingSpeed { get; private set; }
        [field: SerializeField] public Transform FirePoint { get; private set; }
        [field: SerializeField] public GameObject BulletPrefab { get; private set; }
        
    }
}
