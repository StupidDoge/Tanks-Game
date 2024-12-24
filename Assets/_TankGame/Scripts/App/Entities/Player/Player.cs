using Assets.Scripts.Data;
using Assets.Scripts.Services.PersistentProgress;
using TankGame.Core.Utils;
using UnityEngine;
using UnityEngine.SceneManagement;

[SelectionBase]
[RequireComponent(typeof(PlayerMovement))]
public class Player : MonoBehaviour, IDamageable, ISavedProgress, IPlayer
{
    [SerializeField] private PlayerWeapon _weapon;
    [SerializeField] private PlayerHealthData _healthData;

    private PlayerMovement _playerMovement;
    private ISpawnersObserverService _spawnersObserverService;

    private string CurrentLevel => SceneManager.GetActiveScene().name;

    public IHealth Health { get; private set; }
    public PlayerWeapon Weapon => _weapon;
    public Transform Transform => transform;

    public void Init(IInputService inputService, ISpawnersObserverService spawnersObserverService)
    {
        Health = new PlayerHealth(_healthData.MaxHealth, _healthData.MaxHealth);
        _playerMovement = GetComponent<PlayerMovement>();
        _playerMovement.Init(inputService);
        _weapon.Init(inputService);
        _spawnersObserverService = spawnersObserverService;

        _spawnersObserverService.OnAllEnemiesKilled += DeactivatePlayer;
        Health.OnDied += DeactivatePlayer;
    }

    public void UpdateProgress(PlayerProgress playerProgress)
    {
        playerProgress.PlayerData.Health = Health.Value;
        playerProgress.PlayerData.PositionOnLevel = new(CurrentLevel, transform.position.AsVectorData());
    }

    public void LoadProgress(PlayerProgress playerProgress)
    {
        if (CurrentLevel == playerProgress.PlayerData.PositionOnLevel.Level
            && playerProgress.PlayerData.PositionOnLevel.Position != null)
        {
            var savedPosition = playerProgress.PlayerData.PositionOnLevel.Position;
            transform.position = savedPosition.AsUnityVector3();
        }

        Health.SetValue(playerProgress.PlayerData.Health != 0 ? playerProgress.PlayerData.Health : Health.MaxValue);
    }

    public void TakeDamage(float damage)
    {
        Health.Subtract(damage);
    }

    private void DeactivatePlayer()
    {
        _playerMovement.enabled = false;
        _weapon.enabled = false;
        gameObject.SetActive(false);
    }

    private void OnDestroy()
    {
        _spawnersObserverService.OnAllEnemiesKilled -= DeactivatePlayer;
        Health.OnDied -= DeactivatePlayer;
    }
}
