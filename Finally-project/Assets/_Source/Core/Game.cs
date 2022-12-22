using _Source.Input;
using _Source.Services;
using UnityEngine;

namespace _Source.Core
{
    public class Game
    {
        private PlayerInput _input;
        private InputHandler _inputHandler;
        private SpawnerGameObject _spawner;
        public static ObjectPool ObjectPool { get; private set; }
        public Game(PlayerInput input,InputHandler inputHandler, ObjectPool pool, SpawnerGameObject spawner)
        {
            _input = input;
            _inputHandler = inputHandler;
            ObjectPool = pool;
            _spawner = spawner;
            Bind();
        }

        public void StartGame()
        {
            EnableInput();
        }

        public void SpawnBlins(int count, GameObject firstType, GameObject secondType, Vector3 position)
        {
            for (int i = 0; i < count; i++)
            {
                Transform blin;
                if (i % 2 == 1)
                {
                    blin = _spawner.SpawnObject(firstType).transform;
                }
                else
                {
                    blin = _spawner.SpawnObject(secondType).transform;
                }
                blin.transform.position = position;
            }
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