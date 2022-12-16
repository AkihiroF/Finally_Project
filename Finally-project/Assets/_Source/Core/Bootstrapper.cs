using UnityEngine;

namespace _Source.Core
{
    public class Bootstrapper : MonoBehaviour
    {
        private void Awake()
        {
            var input = new PlayerInput();
            var game = new Game(input);
        }
    }
}
