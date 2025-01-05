using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class GameObjectDisabler : MonoBehaviour
{
    [SerializeField] private UnityEvent<View> _OnPoolReturn;


    public void Disable(Collider2D collider)
    {
        var boxCollider2D = gameObject.GetComponent<BoxCollider2D>();

        var bombInteract = collider.GetComponent<BombInteract>();

        if (bombInteract.enabled)
        {
            boxCollider2D.isTrigger = false;
            print("Бомбочка");
        }

        else
        {
            print("Объект");
            boxCollider2D.isTrigger = true;
            collider.gameObject.SetActive(false);
            _OnPoolReturn.Invoke(collider.GetComponent<View>());
        }
    }
}