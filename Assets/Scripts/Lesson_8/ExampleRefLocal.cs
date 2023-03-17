using System;
using UnityEngine;

namespace Geekbrains
{
    public sealed class ExampleRefLocal
    {
        public void Main()
        {
            int readonlyArgument = 44;
            InArgExample(readonlyArgument);
            Debug.Log(readonlyArgument); // value is still 44

            void InArgExample(in int number)
            {
                // Uncomment the following line to see error CS8331
                //number = 19;
            }
            this.NameMethod();
            void NameMethod()
            {
            
            }
            
            int temp = 42;
            ref int tempReference = ref temp;

            ref int t = ref Find(6, new[] {1, 2, 3, 4, 5, 6, 7, 8, 9});
        }

        private void NameMethod()
        {
            
        }

        private ref int Find(int number, int[] numbers)
        {
            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                {
                    return ref numbers[i]; // возвращаем ссылку на адрес, а не само значение
                }
            }
            throw new IndexOutOfRangeException("число не найдено");
        }

    }
}
