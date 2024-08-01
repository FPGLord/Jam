using UnityEngine;
using UnityEngine.Events;


public class ViewDataComparer : MonoBehaviour
    {
        [SerializeField] private Data _targetData;
        [SerializeField] private UnityEvent<Data> _OnEquals, _OnNotEquals;
       

        public void Compare(Collider2D viewCollider)
        {
          var view = viewCollider.GetComponent<View>();

          UnityEvent<Data> unityEvent = view.data == _targetData ? _OnEquals : _OnNotEquals;
          unityEvent.Invoke(view.data);
          
        }
        
    }
