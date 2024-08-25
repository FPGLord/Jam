using UnityEngine;

    public class GameObjectDisabler : MonoBehaviour
    {
        public void Disable(Collider2D collider)
        {
            collider.gameObject.SetActive(false);
        }
        
    }
