using UnityEngine;

namespace _Source.Player
{
    [CreateAssetMenu(fileName = "Parameters Player", menuName = "Player/Player Parameters")]
    public class PlayerParametersSo : ScriptableObject
    {
        public float powerGun;
        public float powerShot;
        public float recoverySpeed;
        public GameObject bulletPrefs;
        public float speedBullet;
    }
}