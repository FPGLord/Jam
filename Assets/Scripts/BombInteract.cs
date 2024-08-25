using System.Collections;
using UnityEngine;

public class BombInteract : MonoBehaviour
{
    [SerializeField] private GlobalVector3Event _globalEvent;
    [SerializeField] private BoolStorage _isInputActive;

    private void Start()
    {
    }

    private void OnMouseDown()
    {
        if (!_isInputActive.Value)
            return;

        
        if (!enabled)
            return;
        

        _globalEvent.Invoke(transform.position);
        StartCoroutine(Disable());
    }

    private IEnumerator Disable()
    {
        yield return new WaitForSeconds(2f);
        gameObject.SetActive(false);
    }
}