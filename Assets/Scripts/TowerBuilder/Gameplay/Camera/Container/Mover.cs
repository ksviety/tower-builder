using TowerBuilder.Data.Preferences;
using TowerBuilder.Data.Values;
using TowerBuilder.Gameplay.Tags;
using UnityEngine;
using Zenject;

namespace TowerBuilder.Gameplay.Camera.Container
{
    [AddComponentMenu("Gameplay/Camera/Container/Mover")]
    [DisallowMultipleComponent]
    public class Mover : MonoBehaviour
    {
        private Transform _target;
        private FloatConstant _speed;

        [Inject]
        private void Construct(CameraTargetTag target, ICameraContainerPreferences preferences)
        {
            _target = target.transform;
            _speed = preferences.MovementSpeed;
        }

        private void LateUpdate()
        {
            var current = transform.position;
            var destination = _target.position;
            var factor = _speed.Value * Time.deltaTime;

            transform.position = Vector3.Lerp(current, destination, factor);
        }
    }
}
