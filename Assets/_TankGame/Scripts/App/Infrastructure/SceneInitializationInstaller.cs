﻿using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace TankGame.App.Infrastructure
{
    public class SceneInitializationInstaller : MonoInstaller
    {
        [SerializeField] private List<MonoBehaviour> _initializers;

        public override void InstallBindings()
        {
            foreach (MonoBehaviour initializer in _initializers)
            {
                Container.BindInterfacesTo(initializer.GetType()).FromInstance(initializer).AsSingle();
            }
        }
    }
}