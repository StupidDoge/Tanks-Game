﻿using System;
using TankGame.Core.Scripts.Data;

namespace Assets.Scripts.Data
{
    [Serializable]
    public class PlayerProgress
    {
        public int TestValue;

        public KillData KillData;
        public PlayerData PlayerData;

        public PlayerProgress(string initialLevel) 
        {
            KillData = new KillData();
            PlayerData = new PlayerData(initialLevel);
        }
    }
}