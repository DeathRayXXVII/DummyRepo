using UnityEngine;

namespace Scripts
{
    [RequireComponent(typeof(Rigidbody))]
    public class BulletBehaviour : MonoBehaviour
    {
        public float force = 100;
        private Rigidbody rigidbodyObj;
        void Awake()
        {
            rigidbodyObj = GetComponent<Rigidbody>();
        
            gameObject.SetActive(false);
        }
    

        private void OnEnable()
        {
            rigidbodyObj.AddForce(Vector3.left*force);
        }

        private void OnTriggerEnter(Collider other)
        {
            rigidbodyObj.Sleep();
            gameObject.SetActive(false);
        }
    }
}
