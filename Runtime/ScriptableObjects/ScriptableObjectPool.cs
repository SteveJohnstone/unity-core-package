
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Pool;

namespace SteveJstone
{
    public class ScriptableObjectPool<T> : ScriptableObject where T : MonoBehaviour
    {
        [AssetsOnly]
        [SerializeField] private T _prefab;
        [SerializeField] private int _poolDefaultCapacity = 10;
        [SerializeField] private int _poolSize = 20;

        private ObjectPool<T> _pool;

        public void OnEnable()
        {
            _pool = new ObjectPool<T>(
                () => Instantiate(_prefab),
                (enemy) => enemy.gameObject.SetActive(true),
                (enemy) => enemy.gameObject.SetActive(false),
                (enemy) => Destroy(enemy),
                false, _poolDefaultCapacity, _poolSize
                );
        }

        public T Get() => _pool.Get();

        public void Release(T element) => _pool.Release(element);
    }
}