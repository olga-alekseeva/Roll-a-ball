using System;
using UnityEngine;

namespace Geekbrains
{
    public sealed class ExampleRaycast
    {
        public void Main()
        {
            Example(out var x, out var y);
            Example(out _, out var y2);
            Example(out var x2, out _);
            Example(out _, out _);
            
            if (Int32.TryParse("8", out _))
            {
                
            }
            
            if (Physics.Raycast(new Ray(), out _))
            {
                
            }
        }

        private void Example(out int x, out int y)
        {
            x = 10;
            y = 10;
        }

        private void NameMethod()
        {
            int t = 7;
            ExampleOne(out t);
            int t1 = 7;
            ExampleTwo(ref t1);
            int t2 = 9;
            Example(in t2);
        }

        private void ExampleOne(out int value)
        {
            value = 5;
        }

        private void ExampleTwo(ref int value)
        {
            value = 7;
        }

        private void Example(in int value)
        { 
            //value = 7;
        }

        private void ExampleR(in MyClass value)
        {
        }

        private void ExampleR3(ref MyClass value)
        {
        }

        private void ExampleR3(MyClass value)
        {
        }

        private void ExampleR4(MyClass _)
        {
        }

        internal class MyClass
        {
            
        }
    }
}
