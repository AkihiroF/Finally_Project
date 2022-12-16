namespace _Source.Core
{
    public class Game
    {
        private PlayerInput _input;
        public Game(PlayerInput input)
        {
            _input = input;
        }
        
        private void Bind()
        {
            
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