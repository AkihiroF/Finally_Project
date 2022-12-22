using System;
using _Source.Core;
using _Source.Services;
using UnityEngine;
using Object = System.Object;

namespace _Source.Player
{
    public class PlayerFire : MonoBehaviour
    {
        [SerializeField] private Transform dulo;
        [SerializeField] private Transform pointFire;
        private ObjectPool _pool;
        private GameObject _bulletPrefab;
        private float _speedBullet;
        private float _maxPowerGun;
        private float _powerShot;
        private float _recoverySpeed;
        private float _currentPower;
        public void SetParameters(PlayerParametersSo parameters)
        {
            _maxPowerGun = parameters.powerGun;
            _powerShot = parameters.powerShot;
            _recoverySpeed = parameters.recoverySpeed;
            _bulletPrefab = parameters.bulletPrefs;
            _currentPower = _maxPowerGun;
            _speedBullet = parameters.speedBullet;
            _pool =Game.ObjectPool;
        }
        
        

        public void Fire()
        {
            if (_currentPower >= _powerShot)
            {
                //_currentPower -= _powerShot;
                var bullet = _pool.GetObject(typeof(Rigidbody));
                if (bullet is GameObject)
                {
                    var obj = (GameObject)bullet;
                    obj.transform.position = pointFire.position;
                    obj.SetActive(true);
                    obj.GetComponent<Rigidbody>().AddForce(dulo.up * _speedBullet, ForceMode.Impulse);
                }

                if (bullet is Rigidbody)
                {
                    var obj = (Rigidbody)bullet;
                    obj.gameObject.SetActive(true);
                    obj.transform.position = pointFire.position;
                    obj.AddForce(dulo.up* _speedBullet);
                }
            }
        }
    }
}
