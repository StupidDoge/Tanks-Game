﻿using TankGame.Core.Utils.Enums;
using UnityEngine;

namespace TankGame.App.StaticData
{
    [CreateAssetMenu(fileName = "projectileData", menuName = "StaticData/Projectiles")]
    public class ProjectileStaticData : ScriptableObject
    {
        [SerializeField] private ProjectileTypeId _projectileTypeId;
        [SerializeField, Min(1)] private float _moveSpeed = 10;
        [SerializeField, Min(1)] private float _damage;
        [SerializeField, Min(1)] private float _lifetime;
        [SerializeField] private Sprite _sprite;

        public ProjectileTypeId Id => _projectileTypeId;
        public float MoveSpeed => _moveSpeed;
        public float Damage => _damage;
        public float Lifetime => _lifetime;
        public Sprite Sprite => _sprite;
    }

    [CreateAssetMenu(fileName = "objectPoolData", menuName = "StaticData/Pools")]
    public class ObjectPoolStaticData : ScriptableObject
    {
        [SerializeField] private GameObject _prefab;
        [SerializeField] private int _poolSize;
        [SerializeField] private bool _autoExpand;

        public GameObject Prefab => _prefab;
        public int PoolSize => _poolSize;
        public bool AutoExpand => _autoExpand;
    }
}