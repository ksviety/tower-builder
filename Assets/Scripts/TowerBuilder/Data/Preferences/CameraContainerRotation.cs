using System;
using TowerBuilder.Data.Values;
using TowerBuilder.Gameplay.Camera.Container;
using UnityEngine;

namespace TowerBuilder.Data.Preferences
{
    [Serializable]
    public struct CameraContainerRotation : IRotationPreferences
    {
        [Tooltip("Angle the camera container rotates per rotation step")] [SerializeField]
        private FloatConstant _step;

        [Tooltip("Axis the camera container rotates around")] [SerializeField]
        private Vector3Constant _axis;

        [SerializeField] private FloatConstant _speed;

        public FloatConstant Step => _step;
        public Vector3Constant Axis => _axis;
        public FloatConstant Speed => _speed;
    }
}