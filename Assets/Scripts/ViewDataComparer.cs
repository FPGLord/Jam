using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class ViewDataComparer : MonoBehaviour
    {
        [SerializeField] private Data _targetData;
        [SerializeField] private UnityEvent _OnEquals, _OnNotEquals;
       

        private void Compare(Collider2D viewCollider)
        {
          var view = viewCollider.GetComponent<View>();

          UnityEvent unityEvent = view.data == _targetData ? _OnEquals : _OnNotEquals;
          unityEvent.Invoke();

        }
        
    }
