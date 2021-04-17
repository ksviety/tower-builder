using System;
using UnityEngine;

namespace TowerBuilder.Gameplay.Camera.Container
{
    [AddComponentMenu("Gameplay/Camera/Container/Rotator")]
    [DisallowMultipleComponent]
    public class Rotator : MonoBehaviour
    {
        private const float Speed = 8f;
        
        private static readonly Vector3 RotationAxis = Vector3.down;

        [Tooltip("Rotation step angle")]
        [SerializeField] private float _step = 90f;

        [SerializeField] private KeyCode _rotateTowardsKey = KeyCode.E;
        [SerializeField] private KeyCode _rotateBackwardsKey = KeyCode.Q;

        /// <summary>
        /// Current rotation the container will rotate towards to
        /// </summary>
        private Quaternion _destination;

        private void Start()
        {
            _destination = transform.localRotation;
        }

        private void LateUpdate()
        {
            var direction = Direction.None;
            
            if (Input.GetKeyDown(_rotateTowardsKey))
                direction = Direction.Towards;
            else if (Input.GetKeyDown(_rotateBackwardsKey))
                direction = Direction.Backwards;

            if (direction != Direction.None)
            {
                // ReSharper disable once SwitchExpressionHandlesSomeKnownEnumValuesWithExceptionInDefault
                var angle = direction switch
                {
                    Direction.Towards => _step,
                    Direction.Backwards => -_step,
                    _ => throw new ArgumentOutOfRangeException(nameof(direction))
                };
                
                _destination *= Quaternion.AngleAxis(angle, RotationAxis);
            }

            var current = transform.localRotation;
            var factor = Speed * Time.deltaTime;
            
            transform.localRotation = Quaternion.Slerp(current, _destination, factor);
        }
        
        private enum Direction
        {
            Towards,
            Backwards,
            None
        }
    }
}