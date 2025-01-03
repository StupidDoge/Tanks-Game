﻿using System;
using System.Threading.Tasks;
using TankGame.App.Entities.Enemies.Base;
using TankGame.App.Entities.Interfaces;
using TankGame.App.Factory;
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
        private bool _isRandom;
        private IGameFactory _gameFactory;
        private bool _IsSlain;
        private IPlayer _player;
        private Enemy _enemy;

        public bool IsSlain => _IsSlain;

        public void Construct(IGameFactory gameFactory)
        {
            _gameFactory = gameFactory;
        }

        public void SetSpawnData(string id, EnemyTypeId enemyType, bool isRandom)
        {
            _id = id;
            _enemyType = enemyType;
            _isRandom = isRandom;
        }

        public void InitPlayer(IPlayer player)
        {
            _player = player;
        }

        public void LoadProgress(PlayerProgress playerProgress)
        {
            if (playerProgress.KillData.ClearedSpawners.Contains(_id))
            {
                _IsSlain = true;
            }
            else
            {
                Spawn();
            }
        }

        public void UpdateProgress(PlayerProgress playerProgress)
        {
            if (_IsSlain)
            {
                playerProgress.KillData.ClearedSpawners.Add(_id);
            }
        }

        private async void Spawn()
        {
            _enemy = await _gameFactory.CreateEnemyAsync(_enemyType, transform);

            _enemy.OnKilled += KillEnemy;
            _enemy.Init(_player);
        }

        private async Task<Enemy> CreateRandomEnemy()
        {
            int enemyType = UnityEngine.Random.Range(0, 2);
            _enemy = enemyType == 0
                ? await _gameFactory.CreateEnemyAsync(EnemyTypeId.Tank, transform)
                : await _gameFactory.CreateEnemyAsync(EnemyTypeId.Turret, transform);

            return _enemy;
        }

        private void KillEnemy()
        {
            _enemy.OnKilled -= KillEnemy;
            _IsSlain = true;

            OnEnemyInSpawnerKilled?.Invoke(this);
        }
    }
}