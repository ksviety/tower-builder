using UnityEngine;

namespace TowerBuilder.Data.Values
{
    public abstract class Constant<T> : ScriptableObject
    {
        [SerializeField] private T _value;

        public T Value => _value;
    }
}