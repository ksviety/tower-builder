using System;
using TowerBuilder.Data.Values;
using TowerBuilder.Gameplay.Camera.Container;
using UnityEngine;

namespace TowerBuilder.Data.Preferences
{
    [Serializable]
    public class CameraContainerMovement : IMovementPreferences
    {
        [SerializeField] private FloatConstant _speed;

        public FloatConstant Speed => _speed;
    }
}