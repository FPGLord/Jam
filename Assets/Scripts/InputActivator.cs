using UnityEngine;
using UnityEngine.InputSystem;


public class InputActivator : MonoBehaviour
{
    [SerializeField] private BoolStorage _inputState;
    [SerializeField] private PlayerInput _playerInput;

    public void SetActive(bool inputState)
    {
        _inputState.Value = inputState;

        if (inputState)
            _playerInput.ActivateInput();
        else
            _playerInput.DeactivateInput();
    }
}