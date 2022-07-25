using Sirenix.OdinInspector;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace SteveJstone
{
    public class ScriptableList<T> : ScriptableObject
    {
        [SerializeField] private List<ScriptableListItem> _items;

        public List<ScriptableListItem> Items => _items;

        [Serializable]
        public class ScriptableListItem
        {
            public string id;
            [AssetsOnly]
            public T item;
        }

        public T Get(string id)
        {
            var item = _items.Find(x => x.id == id);
            Assert.IsNotNull(item, $"{name}: Unable to find '{id}'");
            return item.item;
        }
    }
}
