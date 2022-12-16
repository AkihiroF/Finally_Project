using _Source.Input;
using _Source.Player;

namespace _Source.Core
{
    public class Game
    {
        private PlayerInput _input;
        private InputHandler _inputHandler;
        public Game(PlayerInput input,InputHandler inputHandler)
        {
            _input = input;
            _inputHandler = inputHandler;
            Bind();
        }

        public void StartGame()
        {
            EnableInput();
        }
        
        private void Bind()
        {
            _input.Player.FireMouse.performed += _inputHandler.InputFire;
            _input.Player.FireKeyBoard.performed += _inputHandler.InputFire;
        }

        public void EnableInput()
        {
            _input.Player.Enable();
        }

        public void DisableInput()
        {
            _input.Player.Disable();
        }
    }
}