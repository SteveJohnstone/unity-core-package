using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;

namespace SteveJstone
{
    public class Destructable: MonoBehaviour
    {
        public event UnityAction OnDestruction = delegate { };

        [Button]
        public void Destruct()
        {
            OnDestruction?.Invoke();
        }
    }
}
