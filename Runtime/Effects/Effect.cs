using Sirenix.OdinInspector;
using System;
using System.Collections;
using UnityEngine;

public class Effect : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystem;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private float _duration;

    public void Trigger(Action<Effect> onComplete)
    {
        Trigger();

        StartCoroutine(WaitForCompletion(onComplete));
    }

    [Button]
    public void Trigger()
    {
        _audioSource.PlayOneShot(_audioSource.clip);
        _particleSystem.Play(true);
    }

    private IEnumerator WaitForCompletion(Action<Effect> onComplete)
    {
        yield return new WaitForSeconds(_duration);
        onComplete(this);
    }
}
