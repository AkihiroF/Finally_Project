using _Source.Input;
using _Source.Player;
using _Source.Services;
using UnityEngine;

namespace _Source.Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private PlayerFire playerFire;
        private void Awake()
        {
            var input = new PlayerInput();
            var inputHandler = new InputHandler(playerFire);
            var game = new Game(input, inputHandler);
            
            game.StartGame();
        }
    }
}
