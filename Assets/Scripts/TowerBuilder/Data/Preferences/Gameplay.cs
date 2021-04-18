using UnityEngine;

namespace TowerBuilder.Data.Preferences
{
    [CreateAssetMenu(fileName = "GameplayPreferences", menuName = "Preferences/Gameplay", order = 0)]
    public class Gameplay : ScriptableObject, IGameplayPreferences
    {
        [SerializeField] private CameraContainer _cameraContainer;

        public ICameraContainerPreferences CameraContainer => _cameraContainer;
    }
}