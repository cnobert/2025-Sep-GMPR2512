using UnityEngine;
using UnityEngine.InputSystem;

namespace Lesson09_Input_and_Transform
{
    public class Ship : MonoBehaviour
    {
        private InputAction _moveAction, _spinAction, _scaleAction;

        [SerializeField] private float _movementSpeed = 5, _scaleSpeed = 10; 
        [SerializeField] private float _spinSpeed = 500, _minRotation = 25, _maxRotation = -25;

        void Awake()
        {
            //this creates an input method that is decoupled from the input device
            _moveAction = InputSystem.actions.FindAction("Ship/Move");
            _spinAction = InputSystem.actions.FindAction("Ship/Rotate");
            _scaleAction = InputSystem.actions.FindAction("Ship/Scale");
        }

        #region input disable/enable
        //Unity will keep the input actions disabled by default
        //for efficiency reasons. So, we need to enable/disable them.
        //It's best practice to include the methods below.
        void OnEnable()
        {
            if (_moveAction != null)
            {
                _moveAction.Enable();
            }
            if (_spinAction != null)
            {
                _spinAction.Enable();
            }
            if(_scaleAction != null)
            {
                _scaleAction.Enable();
            }
        }
        void OnDisable()
        {
            if (_moveAction != null)
            {
                _moveAction.Disable();
            }
            if (_spinAction != null)
            {
                _spinAction.Disable();
            }
            if(_scaleAction != null)
            {
                _scaleAction.Disable();
            }
        }
        #endregion
        
        void Update()
        {
            #region movement
            Vector2 moveDirection = _moveAction.ReadValue<Vector2>();
            Vector2 translation = moveDirection * _movementSpeed * Time.deltaTime;
            transform.Translate(translation, Space.World);
            #endregion

            #region rotation
            //exercise: give the player the ability to spin the triangle in 
            // either direction by pressing “j” or “k”

            float spinValue = _spinAction.ReadValue<float>() * _spinSpeed * Time.deltaTime;
            transform.Rotate(0, 0, spinValue);
            
            // Clamp rotation
            Vector3 euler = transform.eulerAngles;

            // Convert to signed range (-180 to 180)
            if (euler.z > 180f)
            {
                euler.z -= 360f;
            }
            // Clamp, then assign back
            euler.z = Mathf.Clamp(euler.z, _maxRotation, _minRotation);
            transform.eulerAngles = euler;
            #endregion

            #region scaling (grow and shrink)
            float scaleValue = _scaleAction.ReadValue<float>() * _scaleSpeed * Time.deltaTime;
            Vector3 scaleChange = new Vector3(scaleValue, scaleValue, scaleValue);
            transform.localScale += scaleChange;
            
            //prevent the transform's scale from becoming negative
            Vector3 scale = transform.localScale;
            if (scale.x < 0)
            {
                scale.x = 0;
            }
            if (scale.y < 0)
            {
                scale.y = 0;
            }
            if (scale.z < 0)
            {
                scale.z = 0;
            }
            transform.localScale = scale;
            #endregion
        }
    }
}
