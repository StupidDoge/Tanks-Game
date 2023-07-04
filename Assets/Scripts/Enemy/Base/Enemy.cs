using System.Collections;
using UnityEngine;
using System;

public class Enemy : MonoBehaviour, IDamageable
{
    public event Action<float, float> OnEnemyTookDamage;

    [SerializeField] private EnemyData _enemyData;
    [SerializeField] private Transform _bulletSpawn;
    [SerializeField] private float _rotationInterpolationFactor = 0.05f;

    private EnemyVisuals _enemyVisuals;
    private readonly float _rotationThreshold = 10f;

    public StateMachine StateMachine { get; private set; }
    public Transform Player { get; private set; }
    public Rigidbody2D Rigidbody { get; private set; }
    public BaseProjectilePool ProjectilePool { get; protected set; }
    public Projectile Projectile { get; protected set; }

    public EnemyData EnemyData => _enemyData;
    public Transform BulletSpawn => _bulletSpawn;

    public bool CanShoot { get; private set; } = true;
    public bool IsRotatingTower { get; private set; }
    public float CurrentHealth { get; private set; }
    public float MaxHealth { get; private set; }

    public virtual void Awake()
    {
        StateMachine = new();
        MaxHealth = _enemyData.MaxHealth;
        CurrentHealth = MaxHealth;
        Player = FindObjectOfType<PlayerMovement>().transform;
        Rigidbody = GetComponent<Rigidbody2D>();
        _enemyVisuals = GetComponent<EnemyVisuals>();
    }

    public virtual void Update()
    {
        StateMachine.CurrentState.LogicUpdate();
    }

    public virtual void FixedUpdate()
    {
        StateMachine.CurrentState.PhysicsUpdate();
    }

    public bool ObstacleBetweenEnemyAndPlayer()
    {
        Vector2 direction = Player.position - transform.position;
        float distance = Vector2.Distance(transform.position, Player.position);
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, distance, EnemyData.DetectionObstacleLayer);

        return hit.collider != null;
    }

    public bool PlayerDetected()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, EnemyData.DetectionDistance, EnemyData.PlayerLayer);

        foreach (Collider2D collider in colliders)
        {
            if (collider.transform == Player)
            {
                return true;
            }
        }

        return false;
    }

    public void RotateTowerTowardsPlayer(Transform tower)
    {
        Vector2 direction = Player.position - tower.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion targetRotation = Quaternion.AngleAxis(angle - 90f, Vector3.forward);
        tower.rotation = Quaternion.Slerp(tower.rotation, targetRotation, _rotationInterpolationFactor * EnemyData.TowerRotationSpeed * Time.deltaTime);

        if (Quaternion.Angle(tower.rotation, targetRotation) > _rotationThreshold)
        {
            IsRotatingTower = true;
        }
        else
        {
            IsRotatingTower = false;
        }
    }

    public virtual void TakeDamage(float damage)
    {
        CurrentHealth -= damage;
        OnEnemyTookDamage?.Invoke(CurrentHealth, EnemyData.MaxHealth);

        if (CurrentHealth <= 0)
        {
            _enemyVisuals.PlayExplosionAnimation();
        }
    }

    public virtual void Shoot()
    {
        StartCoroutine(Reload());
    }

    private IEnumerator Reload()
    {
        CanShoot = false;
        yield return new WaitForSeconds(_enemyData.ReloadTime);
        CanShoot = true;
    }
}
