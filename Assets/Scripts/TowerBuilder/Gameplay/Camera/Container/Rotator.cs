using System;
using TowerBuilder.Data.Values;
using UnityEngine;
using Zenject;

namespace TowerBuilder.Gameplay.Camera.Container
{
    [AddComponentMenu("Gameplay/Camera/Container/Rotator")]
    [DisallowMultipleComponent]
    public class Rotator : MonoBehaviour
    {
        private Vector3Constant _axis;

        /// <summary>
        ///     Current rotation the container will rotate towards to
        /// </summary>
        private Quaternion _destination;

        private FloatConstant _speed;
        private FloatConstant _step;

        private void Start()
        {
            _destination = transform.localRotation;
        }

        private void LateUpdate()
        {
            var direction = Direction.None;

            if (Input.GetKeyDown(KeyCode.E))
                direction = Direction.Towards;
            else if (Input.GetKeyDown(KeyCode.Q))
                direction = Direction.Backwards;

            if (direction != Direction.None)
            {
                var step = _step.Value;

                // ReSharper disable once SwitchExpressionHandlesSomeKnownEnumValuesWithExceptionInDefault
                var angle = direction switch
                {
                    Direction.Towards => step,
                    Direction.Backwards => -step,
                    _ => throw new ArgumentOutOfRangeException(nameof(direction))
                };

                _destination *= Quaternion.AngleAxis(angle, _axis.Value);
            }

            var current = transform.localRotation;
            var factor = _speed.Value * Time.deltaTime;

            transform.localRotation = Quaternion.Slerp(current, _destination, factor);
        }

        [Inject]
        private void Construct(ICameraContainerPreferences preferences)
        {
            _speed = preferences.RotationSpeed;
            _step = preferences.RotationStep;
            _axis = preferences.RotationAxis;
        }

        private enum Direction
        {
            Towards,
            Backwards,
            None
        }
    }
}