using TowerBuilder.Gameplay.Tags;
using UnityEngine;
using Zenject;

namespace TowerBuilder.Gameplay.Camera.Container
{
    [AddComponentMenu("Gameplay/Camera/Container/Mover")]
    [DisallowMultipleComponent]
    public class Mover : MonoBehaviour
    {
        [SerializeField] private float _speed = 8f;
        
        private Transform _target;

        [Inject]
        public void Construct(CameraTargetTag target)
        {
            _target = target.transform;
        }

        private void LateUpdate()
        {
            var current = transform.position;
            var destination = _target.position;
            var factor = _speed * Time.deltaTime;

            transform.position = Vector3.Lerp(current, destination, factor);
        }
    }
}
