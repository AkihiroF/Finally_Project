using _Source.Core;
using UnityEngine;

namespace _Source.Blins
{
    public class BlinController : MonoBehaviour
    {
        [SerializeField] private LayerMask layerBullet;
        private void OnTriggerEnter(Collider other)
        {
            var obj = other.gameObject;
            if (obj.layer == layerBullet)
            {
                Destroy(this.gameObject);
                Game.ObjectPool.AddObject(typeof(Rigidbody), obj.GetComponent<Rigidbody>());
                obj.SetActive(false);
            }
        }
    }
}
