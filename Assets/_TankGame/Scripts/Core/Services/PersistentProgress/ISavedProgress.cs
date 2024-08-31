﻿using Assets.Scripts.Data;

namespace Assets.Scripts.Services.PersistentProgress
{
    public interface ISavedProgress : ISavedProgressReader
    {
        void UpdateProgress(PlayerProgress playerProgress);
    }
}
