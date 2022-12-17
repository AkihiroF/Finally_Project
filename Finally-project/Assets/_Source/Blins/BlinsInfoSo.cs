using UnityEngine;

namespace _Source.Blins
{
    [CreateAssetMenu(fileName = "Blin", menuName = "Create Blin")]
    public class BlinsInfoSo : ScriptableObject
    {
        public GameObject blinBody;
        public float score;
    }
}
