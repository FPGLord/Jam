using UnityEngine;
using UnityEngine.Events;

public class View : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Data _data;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private UnityEvent<bool> _OnViewData;
    public Data data => _data;


    public void ViewData(Data data)
    {
        _data = data;
        _spriteRenderer.sprite = _data.sprite;
        _rigidbody.gravityScale = _data.fallSpeed;
        _OnViewData.Invoke(_data.isInteractable);
    }

    public void SetActive(bool active)
    {
        gameObject.SetActive(active);
    }

    public void SetPosition(Vector3 position)
    {
        gameObject.transform.position = position;
    }
}