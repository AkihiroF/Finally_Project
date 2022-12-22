using _Source.Blins;
using _Source.Input;
using _Source.Level;
using _Source.Player;
using _Source.Services;
using UnityEngine;

namespace _Source.Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private PlayerFire playerFire;
        [SerializeField] private PlayerParametersSo parametersPlayer;
        [SerializeField] private ParametersLevelSo parametersBlin;
        [SerializeField] private BlinsInfoSo firstTypeBlin;
        [SerializeField] private BlinsInfoSo secondTypeBlin;
        [SerializeField] private Transform positionSpawnBlins;
        [SerializeField] private SpawnerGameObject spawnerGameObject;
        private void Awake()
        {
            var input = new PlayerInput();
            var inputHandler = new InputHandler(playerFire);
            var pool = new ObjectPool(spawnerGameObject);
            var game = new Game(input, inputHandler, pool, spawnerGameObject);
            playerFire.SetParameters(parametersPlayer);
            pool.AddNewType(typeof(Rigidbody));
            pool.AddObject(typeof(Rigidbody), parametersPlayer.bulletPrefs);
            game.StartGame();
            var count = parametersBlin.GetCount(firstTypeBlin) + parametersBlin.GetCount(secondTypeBlin);
            game.SpawnBlins(count, firstTypeBlin.blinBody, secondTypeBlin.blinBody, positionSpawnBlins.position);
        }
    }
}
