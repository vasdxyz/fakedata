using System;
using System.Collections.Generic;
using UnityEngine;

namespace Xyz.Vasd.FakeData
{
    [AddComponentMenu("FakeData/" + nameof(FakeDataBase))]

    public class FakeDataBase : MonoBehaviour
    {
        private Dictionary<Type, object> _singletons = new();

        public T GetSingleton<T>() where T : class, new()
        {
            var type = typeof(T);
            if (_singletons.ContainsKey(type)) return (T)_singletons[type];

            var singleton = new T();
            _singletons[type] = singleton;

            return singleton;
        }
    }
}
