using TowerBuilder.Data.Preferences;
using UnityEngine;
using Zenject;
using GameplayPreferences = TowerBuilder.Data.Preferences.Gameplay;
using ICameraContainerRotationPreference = TowerBuilder.Gameplay.Camera.Container.IRotationPreferences;
using ICameraContainerMovementPreferences = TowerBuilder.Gameplay.Camera.Container.IMovementPreferences;

namespace TowerBuilder.Data.Installers
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
                .Bind<ICameraContainerRotationPreference>()
                .FromInstance(_preferences.CameraContainerRotation)
                .AsCached();
            
            Container
                .Bind<ICameraContainerMovementPreferences>()
                .FromInstance(_preferences.CameraContainerMovement)
                .AsCached();
        }
    }
}