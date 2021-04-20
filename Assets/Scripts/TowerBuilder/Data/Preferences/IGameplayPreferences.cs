using ICameraContainerRotationPreference = TowerBuilder.Gameplay.Camera.Container.IRotationPreferences;
using ICameraContainerMovementPreference = TowerBuilder.Gameplay.Camera.Container.IMovementPreferences;

namespace TowerBuilder.Data.Preferences
{
    public interface IGameplayPreferences
    {
        public ICameraContainerRotationPreference CameraContainerRotation { get; }
        public ICameraContainerMovementPreference CameraContainerMovement { get; }
    }
}