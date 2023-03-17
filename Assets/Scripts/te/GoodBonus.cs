using UnityEngine;

namespace Geekbrains.te
{
    internal sealed class GoodBonus : IBonus
    {
        private readonly Transform _transform;

        public GoodBonus(Transform transform)
        {
            _transform = transform;
            _transform.name = nameof(GoodBonus);
        }
        
        public void Behaviour()
        {
            _transform.position = new Vector3(_transform.position.x,
                Mathf.PingPong(Time.frameCount * 5, 10),
                _transform.position.z);
        }
    }
}
