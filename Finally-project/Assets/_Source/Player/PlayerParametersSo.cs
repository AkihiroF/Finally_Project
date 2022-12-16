using UnityEngine;

namespace _Source.Player
{
    [CreateAssetMenu(fileName = "Parameters Player", menuName = "Player/Player Parameters")]
    public class PlayerParametersSo : ScriptableObject
    {
        [SerializeField] private PlayerParameters parameters;
    }
}