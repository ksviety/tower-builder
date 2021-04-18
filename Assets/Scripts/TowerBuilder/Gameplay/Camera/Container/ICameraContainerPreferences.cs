using TowerBuilder.Data.Values;

namespace TowerBuilder.Gameplay.Camera.Container
{
    public interface ICameraContainerPreferences
    {
        public FloatConstant RotationStep { get; }
        public Vector3Constant RotationAxis { get; }
        public FloatConstant RotationSpeed { get; }
        public FloatConstant MovementSpeed { get; }
    }
}