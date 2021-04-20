using TowerBuilder.Data.Values;

namespace TowerBuilder.Gameplay.Camera.Container
{
    public interface IRotationPreferences
    {
        public FloatConstant Step { get; }
        public Vector3Constant Axis { get; }
        public FloatConstant Speed { get; }
    }
}