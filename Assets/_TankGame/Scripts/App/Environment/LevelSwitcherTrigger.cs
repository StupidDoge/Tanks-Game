﻿using TankGame.App.Infrastructure;
using TankGame.App.Infrastructure.StateMachine;
using TankGame.App.Infrastructure.StateMachine.Interfaces;
using TankGame.Core.Editor;
using TankGame.Core.Utils;
using TankGame.Core.Utils.Enums.Generated;
using UnityEngine;

namespace TankGame.App.Environment
{
    public class LevelSwitcherTrigger : MonoBehaviour
    {
        [SceneNameSelector]
        [SerializeField] private string _sceneName;

        private IGameStateMachine _stateMachine;
        private bool _triggered;

        private void Awake()
        {
            _stateMachine = ServiceLocator.Instance.Single<IGameStateMachine>();
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (_triggered)
            {
                return;
            }

            if (other.gameObject.CompareTag(Tags.Player))
            {
                _stateMachine.Enter<LoadLevelState, string>(_sceneName);
                _triggered = true;
            }
        }
    }
}