using UnityEngine;
using UnityEngine.Events;

public class AudioClipGlabalEventHandler : MonoBehaviour
{
    [SerializeField] private AudioClipGlobalEvent _globalEvent;
    [SerializeField] private UnityEvent<AudioClip> _OnInvoke;
    private void OnEnable()
    {
        _globalEvent.OnInvoke.AddListener(Invoke);
    }
    private void OnDisable()
    {
        _globalEvent.OnInvoke.RemoveListener(Invoke) ;
    }

    void Invoke(AudioClip audioClip)
    {
        _OnInvoke.Invoke(audioClip);
    }
}
