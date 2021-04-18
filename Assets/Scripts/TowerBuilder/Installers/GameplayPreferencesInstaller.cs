using TowerBuilder.Data.Preferences;
using TowerBuilder.Gameplay.Camera.Container;
using UnityEngine;
using Zenject;
using GameplayPreferences = TowerBuilder.Data.Preferences.Gameplay;

namespace TowerBuilder.Installers
{
    [AddComponentMenu("Installers/Gameplay Preferences Installer")]
    public class GameplayPreferencesInstaller : MonoInstaller
    {
        [SerializeField] private GameplayPreferences _preferences;

        public override void InstallBindings()
        {
            Container
                .Bind<IGameplayPreferences>()
                .FromInstance(_preferences)
                .AsCached();

            Container
                .Bind<ICameraContainerPreferences>()
                .FromInstance(_preferences.CameraContainer)
                .AsCached();
        }
    }
}