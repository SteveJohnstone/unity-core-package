using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;

public class Damagable : MonoBehaviour 
{
    public event UnityAction<float> OnDamage = delegate { };

    [Button]
    public void TakeDamage(float amount) 
    {
        OnDamage?.Invoke(amount);
    }
}