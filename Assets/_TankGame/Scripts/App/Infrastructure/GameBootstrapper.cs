using UnityEngine;

public class GameBootstrapper : MonoBehaviour, ICoroutineRunner
{
    [SerializeField] private LoadingScreen _loadingScreen;

    private Game _game;

    private void Awake()
    {
        _game = new Game(this, _loadingScreen);
        _game.StateMachine.Enter<BootstrapState>();
        DontDestroyOnLoad(this);
        //_player.Init(_actionsInputService);
    }
}