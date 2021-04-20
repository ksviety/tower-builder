using ICameraContainerRotationPreference = TowerBuilder.Gameplay.Camera.Container.IRotationPreferences;
using ICameraContainerMovementPreferences = TowerBuilder.Gameplay.Camera.Container.IMovementPreferences;
using UnityEngine;

namespace TowerBuilder.Data.Preferences
{
    [CreateAssetMenu(fileName = "GameplayPreferences", menuName = "Preferences/Gameplay", order = 0)]
    public class Gameplay : ScriptableObject, IGameplayPreferences
    {
        [Header("Camera Container Preferences")]
        [SerializeField] private CameraContainerRotation _cameraContainerRotation;
        [SerializeField] private CameraContainerMovement _cameraContainerMovement;

        public ICameraContainerRotationPreference CameraContainerRotation => _cameraContainerRotation;
        public ICameraContainerMovementPreferences CameraContainerMovement => _cameraContainerMovement;
    }
}