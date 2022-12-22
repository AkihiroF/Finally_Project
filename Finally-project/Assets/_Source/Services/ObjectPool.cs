using System;
using System.Collections.Generic;
using UnityEngine;
using Object = System.Object;

namespace _Source.Services
{
    public class ObjectPool
    {
        private Dictionary<Type, List<object>> _objects;
        private SpawnerGameObject _spawner;

        public ObjectPool(SpawnerGameObject spawner)
        {
            _objects = new Dictionary<Type, List<object>>();
            _spawner = spawner;
        }

        public void AddNewType(Type type)
        {
            try
            {
                _objects.Add(type, new List<object>());
            }
            catch (Exception e)
            {
                Debug.Log("Type in pool");
            }
        }

        public bool AddObject(Type type, object target)
        {
            try
            {
                _objects[type].Add(target);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public Object GetObject(Type type)
        {
            if (_objects[type].Count > 1)
            {
                return _objects[type][1];
            }

            return _spawner.SpawnObject((GameObject)_objects[type][0]);
        }
    }
}