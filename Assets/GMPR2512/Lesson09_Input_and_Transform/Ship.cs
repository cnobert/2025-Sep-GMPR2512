using UnityEngine;
using UnityEngine.InputSystem;

namespace Lesson09_Input_and_Transform
{
    public class Ship : MonoBehaviour
    {
        private InputAction _moveAction, _spinAction;
        [SerializeField] float _movementSpeed, _spinSpeed;

        void Awake()
        {
            //this creates an input method that is decoupled from the input device
            _moveAction = InputSystem.actions.FindAction("Ship/Move");
            _spinAction = InputSystem.actions.FindAction("Ship/Rotate");
        }
        void Update()
        {
            #region movement
            Vector2 moveDirection = _moveAction.ReadValue<Vector2>();
            Debug.Log(moveDirection);
            Vector2 moveVelocity = moveDirection * _movementSpeed * Time.deltaTime;
            transform.Translate(moveVelocity, Space.World);
            #endregion

            #region rotation
            //exercise: give the player the ability to spin the trianble in 
            // either direction by pressing “j” or “k”
            float spinValue = _spinAction.ReadValue<float>() * _spinSpeed * Time.deltaTime;
            transform.Rotate(0, 0, spinValue);
            #endregion
        }
    }
}
