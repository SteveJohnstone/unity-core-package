using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SteveJstone
{
    [RequireComponent(typeof(Destructable))]
    public class DestroyOnDestruction : MonoBehaviour
    {
        public void OnEnable()
        {
            var destructable = GetComponent<Destructable>();
            destructable.OnDestruction += Destroy;
        }

        private void Destroy()
        {
            GameObject.Destroy(gameObject);
        }
    }
}
