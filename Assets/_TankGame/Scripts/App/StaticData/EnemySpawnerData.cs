﻿using System;
using UnityEngine;

[Serializable]
public class EnemySpawnerData
{
    public string Id;
    public EnemyTypeId EnemyTypeId;
    public Vector3 Position;
    public bool IsRandom;

    public EnemySpawnerData(string id, EnemyTypeId enemyTypeId, Vector3 position, bool isRandom)
    {
        Id = id;
        EnemyTypeId = enemyTypeId;
        Position = position;
        IsRandom = isRandom;
    }
}