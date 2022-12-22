using _Source.Player;
using UnityEngine;
using UnityEngine.InputSystem;

namespace _Source.Input
{
    public class InputHandler
    {
        private PlayerFire _player;
        public InputHandler(PlayerFire player)
        {
            _player = player;
        }
        public void InputFire(InputAction.CallbackContext context)
        {
            _player.Fire();
        }
    }
}