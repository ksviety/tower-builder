using TowerBuilder.Gameplay.Camera.Container;

namespace TowerBuilder.Data.Preferences
{
    public interface IGameplayPreferences
    {
        public ICameraContainerPreferences CameraContainer { get; }
    }
}