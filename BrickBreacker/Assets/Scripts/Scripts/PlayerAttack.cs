using Scripts.Data;
using UnityEngine;

namespace Scripts
{
    public class PlayerAttack : MonoBehaviour
    {
        [Header ("Player Attack")]
        public FloatData damage;
        public float attackRange;
        public float attackRate;
        private float lastAttackTime;
        public LayerMask enemyLayer;
        private Vector2 direction;
        public GameObject wepon;
        private AudioSource source;
        public AudioClip marker;

    
        void Start()
        {
            wepon.SetActive(false);
            source = GetComponent<AudioSource>();
        }
        private void OnTriggerEnter3D (Collider other)
        {
            lastAttackTime = Time.time;
        }
    }
}

