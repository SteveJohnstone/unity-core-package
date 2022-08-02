using UnityEngine;
using UnityEngine.Events;

public class CollisionTrigger : MonoBehaviour
{
    [SerializeField] private UnityEvent<GameObject> _onTriggerEnter;
    [SerializeField] private UnityEvent<GameObject> _onTriggerExit;

    public UnityEvent<GameObject> OnEnter => _onTriggerEnter;
    public UnityEvent<GameObject> OnExit => _onTriggerExit;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(nameof(OnTriggerEnter));
        _onTriggerEnter?.Invoke(other.gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        _onTriggerExit?.Invoke(other.gameObject);
    }
}
