using Sirenix.OdinInspector;
using UnityEngine;

namespace SteveJstone
{
    public class Health : MonoBehaviour
    {
        [SerializeField] private float _maxHealth = 100;
        [SerializeField] private float _currentHealth = 100;

        [Title("References")]
        [SerializeField] private Damagable _damagable;
        [SerializeField] private Destructable _destructable;

        public float MaxHealth
        {
            get => _maxHealth;
            set
            {
                _maxHealth = value;
                _currentHealth = Mathf.Clamp(value, 0, _maxHealth);
            }
        }
        public float CurrentHealth
        {
            get => _currentHealth;
            set
            {
                _currentHealth = Mathf.Clamp(value, 0, _maxHealth);
            }
        }

        public void OnEnable()
        {
            _currentHealth = _maxHealth;
            _damagable.OnDamage += TakeDamage;
        }

        private void TakeDamage(float amount)
        {
            _currentHealth -= amount;

            if (_currentHealth <= 0)
            {
                _destructable.Destruct();
            }
        }

        private void OnValidate()
        {
            _currentHealth = Mathf.Clamp(_currentHealth, 0, _maxHealth);

            if (_damagable == null) _damagable = GetComponent<Damagable>();
            if (_destructable == null) _destructable = GetComponent<Destructable>();
        }
    }
}
