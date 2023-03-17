using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Geekbrains.te
{
    internal class MyClass
    {
        public MyClass()
        {
            Timer(5).StartCoroutine(out _);
        }
        
        IEnumerator Timer(float time)
        {
            yield return new WaitForSeconds(time);
            Debug.Log(Time.time);
        }
    }
    internal sealed class Test : MonoBehaviour
    {
        public GameObject _prefab;
        private Controller _controller;

        IEnumerator Timer(float time)
        {
            yield return new WaitForSeconds(time);
            print(Time.time);
        }
        
        private void Start()
        {
            
            return;
            var list = new List<IBonus>();
            for (int i = 0; i < 10; i++)
            {
                if (Random.Range(0, 100) >= 50)
                {
                    IBonus Bonus = new BadBonus(Instantiate(_prefab,
                        new Vector3(0, i, i), Quaternion.identity).transform);
                    list.Add(Bonus);
                }
                else
                {
                    IBonus Bonus = new GoodBonus(Instantiate(_prefab,
                        new Vector3(0, i, i), Quaternion.identity).transform);
                    list.Add(Bonus);
                }
            }
            _controller = new Controller(list);
        }

        private void Update()
        {
            // _controller.OnUpdate();
        }

        private void NameMethod(Action<Action<int>> y)
        {
            
        }

        private void NameMethod()
        {
            NameMethod(action => Y(action => Obj(3)));
        }

        private void Obj(int obj)
        {
            throw new NotImplementedException();
        }

        private void Y(Action<int> obj)
        {
            
        }
    }
}
