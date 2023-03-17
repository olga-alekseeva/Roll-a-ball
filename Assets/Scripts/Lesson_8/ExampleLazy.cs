using System;
using UnityEngine;

namespace Geekbrains
{
    public sealed class ExampleLazy
    {
        private string _title;

        public sealed class Singleton
        {
            private Singleton() { }
            
            private static readonly Lazy<Singleton> _instance = 
                new Lazy<Singleton>(() => new Singleton());

            public static Singleton Instance => _instance.Value;

            public void Test()
            {
                Debug.Log("Hello World");
            }
        }

        internal class MyClass
        {
            private string[] _strings = new string[999999];

            public MyClass(int i)
            {
            }
        }
        public void Main()
        {
            Singleton.Instance.Test();
            MyClass myClass = new MyClass(9);
            Lazy<MyClass> lazy = new Lazy<MyClass>(() => new MyClass(9));
            Debug.Log(lazy.Value);
        }

        public string Title
        {
            get
            {
                if (String.IsNullOrEmpty(_title))
                {
                    _title = "fgfd";
                }

                return _title;
            }
        }
    }
}
