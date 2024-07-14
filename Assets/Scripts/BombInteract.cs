using UnityEngine;

public class BombInteract : MonoBehaviour
{
    [SerializeField] private GlobalVector3Event _globalEvent;
    

    private void Start()
    {
    }

    private void OnMouseDown()
    {
        if (!enabled)
            return;

        _globalEvent.Invoke(transform.position);
        
    }
}