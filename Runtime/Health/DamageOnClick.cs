using Sirenix.OdinInspector;
using UnityEngine;

namespace SteveJstone
{
    public class DamageOnClick : MonoBehaviour
    {
        [SerializeField] private float _damageAmount = 5;

        [Title("References")]
        [SerializeField] private Damagable _damagable;
        [SerializeField] private MouseInteractable _mouseInteractable;

        public void OnEnable()
        {
            _mouseInteractable.OnMouseClick += MouseClicked;
        }

        private void MouseClicked()
        {
            _damagable.TakeDamage(_damageAmount);
        }
    }
}
