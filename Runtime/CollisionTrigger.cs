using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Events;

public class CollisionTrigger : MonoBehaviour
{
    [SerializeField] private UnityEvent<GameObject> _onTriggerEnter;
    [SerializeField] private UnityEvent<GameObject> _onTriggerExit;

    public UnityEvent<GameObject> OnEnter => _onTriggerEnter;
    public UnityEvent<GameObject> OnExit => _onTriggerExit;

    public void Awake()
    {
#if UNITY_EDITOR
        Assert.IsTrue(GetComponent<Collider>().isTrigger, $"{name} collider is not set as a trigger");
#endif
    }

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
