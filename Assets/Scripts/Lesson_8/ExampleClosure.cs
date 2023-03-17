using System;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains
{
    public sealed class ExampleClosure
    {
        public void Main()
        {
            var actions = new List<Action>();
            for (var i = 0; i < 100; i++)
            {
                actions.Add(() =>
                {
                    Debug.Log(i);
                });
            }

            foreach (var action in actions)
            {
                action();
            }
        }
    }
}

