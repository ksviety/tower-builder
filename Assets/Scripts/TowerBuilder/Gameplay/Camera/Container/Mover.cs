using UnityEngine;

namespace TowerBuilder.Gameplay.Camera.Container
{
    [AddComponentMenu("Gameplay/Camera/Container/Mover")]
    [DisallowMultipleComponent]
    public class Mover : MonoBehaviour
    {
        [SerializeField] private float _speed = 8f;
        [SerializeField] private Transform _target;

        private void Update()
        {
            var current = transform.position;
            var destination = _target.position;
            var factor = _speed * Time.deltaTime;

            transform.position = Vector3.Lerp(current, destination, factor);
        }
    }
}
