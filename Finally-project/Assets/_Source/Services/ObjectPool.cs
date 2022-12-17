using System;
using System.Collections.Generic;
using _Source.Core;
using UnityEngine;

namespace _Source.Services
{
    public class ObjectPool
    {
        private Dictionary<GameObject, List<GameObject>> _objectInPool;
        private SpawnerGameObject _spawner;

        public ObjectPool(SpawnerGameObject spawner)
        {
            _objectInPool = new Dictionary<GameObject, List<GameObject>>();
            _spawner = spawner;
        }

        public void AddNewTypeObject(GameObject type)
        {
            if (_objectInPool[type] != null)
            {
                return;
            }
            _objectInPool.Add(type, new List<GameObject>());
        }

        public void AddObjectToPool(GameObject obj)
        {
            try
            {
                _objectInPool[obj].Add(obj);
            }
            catch (Exception e)
            {
                Debug.Log(e);
            }
        }

        // public void ActivateGameObject(Type type, Vector3 position)
        // {
        //     try
        //     {
        //         _objectInPool[type][0].transform.position = position;
        //         _objectInPool[type][0].SetActive(true);
        //     }
        //     catch (Exception e)
        //     {
        //         Debug.Log(e);
        //         if (e.GetType() == typeof(NullReferenceException))
        //         {
        //             AddNewTypeObject(type);
        //         }
        //     }
        // }
    }
}