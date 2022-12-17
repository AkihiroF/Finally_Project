using UnityEngine;

namespace _Source.Services
{
    public class SpawnerGameObject : MonoBehaviour
    {
        public GameObject SpawnObject(GameObject reference)
        {
            return Instantiate(reference);
        }
    }
}