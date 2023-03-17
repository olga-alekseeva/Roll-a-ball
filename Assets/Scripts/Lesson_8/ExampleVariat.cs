using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Geekbrains
{
    internal class ExampleVariat : MonoBehaviour
    {
        private void Start()
        {
             // Base u = new Base();                      //1
             // Base u1 = new Specific();                 //2
             //  Specific u2 = new Specific();             //3
             //  Specific u3 = new Base();                 //4
             // List<Base> b = new List<Base>();          //5
             //  List<Specific> b1 = new List<Specific>(); //6
             //  List<Base> b2 = new List<Specific>();     //7
             // List<Specific> b3 = new List<Base>();     //8

             #region MyRegion

             IEnumerable<Base> b4 = new List<Specific>();
             // Func<>

             #endregion

             #region MyRegion
             
             IComparer<Specific> b5 = new MyClass<Base>();
             // Action<>

             #endregion

             #region MyRegion

                // Converter<>

             #endregion
        }

        internal class Base
        {
            
        }

        internal class Specific : Base
        {
            
        }

        interface IInterface<T>
        {
            
        }

        internal class Test<T> : IInterface<T>
        {
            
        }

        internal class MyClass<T> : IComparer<T>
        {
            public int Compare(T x, T y)
            {
                throw new NotImplementedException();
            }
        }

        internal class MyClass3<T>
        {
            private List<T> List;
        }
    }
}
