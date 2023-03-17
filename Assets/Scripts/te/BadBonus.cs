using UnityEngine;

namespace Geekbrains.te
{
    internal sealed class BadBonus : IBonus
    {
        private readonly Transform _transform;

        public BadBonus(Transform transform)
        {
            _transform = transform;
            _transform.name = nameof(BadBonus);
        }
        
        public void Behaviour()
        {
            _transform.Rotate(Vector3.up * (50 * Time.deltaTime));
        }
    }
}
