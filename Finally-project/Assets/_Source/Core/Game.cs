using _Source.Input;

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

        public void PauseGame()
        {
            DisableInput();
        }
        
        private void Bind()
        {
            _input.Player.FireMouse.performed += _inputHandler.InputFire;
        }

        private void EnableInput()
        {
            _input.Player.Enable();
        }

        private void DisableInput()
        {
            _input.Player.Disable();
        }
    }
}