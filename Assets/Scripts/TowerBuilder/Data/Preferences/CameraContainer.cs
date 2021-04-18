using System;
using TowerBuilder.Data.Values;
using UnityEngine;

namespace TowerBuilder.Data.Preferences
{
    [Serializable]
    public struct CameraContainer : ICameraContainerPreferences
    {
        [Tooltip("Angle the camera container rotates per rotation step")]
        [SerializeField] private FloatConstant _rotationStep;

        [Tooltip("Axis the camera container rotates around")]
        [SerializeField] private Vector3Constant _rotationAxis;

        [SerializeField] private FloatConstant _rotationSpeed;

        [SerializeField] private FloatConstant _movementSpeed;

        public FloatConstant RotationStep => _rotationStep;
        public Vector3Constant RotationAxis => _rotationAxis;
        public FloatConstant RotationSpeed => _rotationSpeed;
        public FloatConstant MovementSpeed => _movementSpeed;
    }
}