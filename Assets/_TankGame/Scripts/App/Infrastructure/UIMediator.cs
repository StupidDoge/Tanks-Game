using System;

public class UIMediator : IDisposable
{
    private readonly IUIService _uiService;
    private readonly Player _player;
    private readonly ISpawnersObserverService _spawnersObserverService;

    public UIMediator(IUIService uiService, Player player, ISpawnersObserverService spawnersObserverService)
    {
        _uiService = uiService;
        _player = player;
        _spawnersObserverService = spawnersObserverService;

        player.Health.OnDied += OnPlayerDied;
        spawnersObserverService.OnAllEnemiesKilled += OnAllEnemiesKilled;
    }

    private void OnPlayerDied()
    {
        _uiService.Open(UIPanelId.FailurePanel);
    }

    private void OnAllEnemiesKilled()
    {
        _uiService.Open(UIPanelId.VictoryPanel);
    }

    public void Dispose()
    {
        _player.Health.OnDied -= OnPlayerDied;
        _spawnersObserverService.OnAllEnemiesKilled -= OnAllEnemiesKilled;
    }
}
