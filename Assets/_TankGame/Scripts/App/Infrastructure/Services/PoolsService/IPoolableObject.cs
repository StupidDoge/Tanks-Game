﻿namespace TankGame.App.Infrastructure.Services.PoolsService
{
    public interface IPoolableObject
    {
        void OnSpawned();
        void ReturnToPool();
        void OnDespawned();
    }
}
