using UnityEngine;

namespace Geekbrains
{
    public sealed class Test : MonoBehaviour
    {
        private void Start()
        {
            new ExampleClosure().Main();
        }
    }
}
