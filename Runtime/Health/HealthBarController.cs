using Sirenix.OdinInspector;
using UnityEngine;

namespace SteveJstone
{
    [ExecuteAlways]
    public class HealthBarController : MonoBehaviour
    {
        [Title("References")]
        [SerializeField] private Health _health;
        [SerializeField] private HealthBar _healthBar;

        public void Update()
        {
            _healthBar.HealthAmount = _health.CurrentHealth / _health.MaxHealth; 
        }

        public void OnValidate()
        {
            if (_health == null) _health = GetComponent<Health>();
            if (_healthBar == null) _healthBar = GetComponentInChildren<HealthBar>();
        }
    }
}
