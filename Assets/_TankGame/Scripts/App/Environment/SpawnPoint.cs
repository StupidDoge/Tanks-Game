﻿using System;
using System.Threading.Tasks;
using TankGame.App.Entities.Enemies.Base;
using TankGame.App.Entities.Interfaces;
using TankGame.App.Factory;
using TankGame.App.Infrastructure.Services.PoolsService;
using TankGame.Core.Data;
using TankGame.Core.Services.PersistentProgress;
using TankGame.Core.Utils.Enums;
using UnityEngine;

namespace TankGame.App.Environment
{
    public class SpawnPoint : MonoBehaviour, ISavedProgress
    {
        public event Action<SpawnPoint> OnEnemyInSpawnerKilled;

        private string _id;
        private EnemyTypeId _enemyType;
        private IGameFactory _gameFactory;
        private bool _isSlain;
        private IPlayer _player;
        private IPoolsService _poolsService;
        private Enemy _enemy;

        public bool IsSlain => _isSlain;

        public void Construct(IGameFactory gameFactory)
        {
            _gameFactory = gameFactory;
        }

        public void SetSpawnData(string id, EnemyTypeId enemyType)
        {
            _id = id;
            _enemyType = enemyType;
        }

        public void Initialize(IPlayer player, IPoolsService poolsService)
        {
            _player = player;
            _poolsService = poolsService;
        }

        public void LoadProgress(PlayerProgress playerProgress)
        {
            if (playerProgress.KillData.ClearedSpawners.Contains(_id))
            {
                _isSlain = true;
            }
            else
            {
                Spawn();
            }
        }

        public void UpdateProgress(PlayerProgress playerProgress)
        {
            if (_isSlain)
            {
                playerProgress.KillData.ClearedSpawners.Add(_id);
            }
        }

        private async void Spawn()
        {
            _enemy = await _gameFactory.CreateEnemyAsync(_enemyType, transform);

            _enemy.OnKilled += KillEnemy;
            _enemy.Initialize(_player, _poolsService);
        }

        private void KillEnemy()
        {
            _enemy.OnKilled -= KillEnemy;
            _isSlain = true;

            OnEnemyInSpawnerKilled?.Invoke(this);
        }
    }
}