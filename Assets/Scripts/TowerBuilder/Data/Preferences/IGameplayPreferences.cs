using TowerBuilder.Data.Values;

namespace TowerBuilder.Data.Preferences
{
    public interface IGameplayPreferences
    {
        public ICameraContainerPreferences CameraContainer { get; }
    }
}