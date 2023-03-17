using System.Collections.Generic;

namespace Geekbrains.te
{
    internal sealed class Controller
    {
        private readonly List<IBonus> _bonuses;

        public Controller(List<IBonus> bonuses)
        {
            _bonuses = bonuses;
        }

        public void OnUpdate()
        {
            foreach (var bonuse in _bonuses)
            {
                bonuse.Behaviour();
            }
        }
    }
}
