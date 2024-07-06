using UnityEngine;

public class View : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Data _data;
    [SerializeField] private Rigidbody2D _rigidbody;
    

    public void ViewData(Data data)
    {
        _data = data;
        _spriteRenderer.sprite = _data.sprite;
        _rigidbody.gravityScale = _data.fallSpeed;
    }
    
    
}
