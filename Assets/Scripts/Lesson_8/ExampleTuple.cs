using System;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains
{
    public sealed class ExampleTuple
    {
        private sealed class Player
        {
            private int _maxHP;
            private int _currentHP;

            public Player()
            {
                _maxHP = 100;
                _currentHP = 42;
            }

            public void Deconstruct(out int currentHP, out int maxHP) =>
                (currentHP, maxHP) = (_currentHP, _maxHP);
        }

        public void Main()
        {
            List<(int, float, 
                long, ExampleTuple, 
                Player, Data)> t = new List<(int, float, long, ExampleTuple, Player, Data)>();
            var nameMethod = NameMethod();
            
            Debug.Log($"{nameMethod.Hp}/{nameMethod.IsDead}");

            Player player = new Player();
            (int currentHP, int maxHP) = player;
            
            Debug.Log($"{currentHP}/{maxHP}");
            
        }

        private Data NameMethod2()
        {
            var result = new Data
            {
                Hp = 7,
                IsDead = false
            };

            return result;
        }

        private Tuple<int, bool> NameMethod3()
        {
            Tuple<int, bool> result = 
                new Tuple<int, bool>(9, false);
            return result;
        }

        private (int, bool) NameMethod4()
        {
            (int, bool) result = (6,false);
            return result;
        }

        private (int Hp, bool IsDead) NameMethod()
        {
            Dictionary<Data, string> t = new Dictionary<Data, string>();
            (int Hp, bool IsDead) result = (6,false);
            return result;
        }

        struct Data
        {
            public int Hp;
            public bool IsDead;

            public override int GetHashCode()
            {
                return 1;
            }
        }
    }
}
