using System.Collections.Generic;
using _Source.Blins;
using _Source.Services;
using UnityEngine;

namespace _Source.Level
{
    [CreateAssetMenu(fileName = "Level", menuName = "Create level")]
    public class ParametersLevelSo : ScriptableObject
    {
        [SerializeField] private List<ParametersLevel> parameters;
        public int GetCount(BlinsInfoSo key)
        {
            return parameters.GetValue(key);
        }
    }
}