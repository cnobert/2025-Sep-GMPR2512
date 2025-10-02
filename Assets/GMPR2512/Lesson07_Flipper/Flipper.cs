using UnityEngine;
using UnityEngine.InputSystem;

namespace GMPR2512.Lesson07_Flipper
{
    public class Flipper : MonoBehaviour
    {
        private HingeJoint2D _joint2D;
        [SerializeField] private bool _rightFlipper;
        void Awake()
        {
            _joint2D = GetComponent<HingeJoint2D>();
        }
        void Update()
        {
            if (_rightFlipper)
            {
                _joint2D.useMotor = Input.GetKey(KeyCode.RightShift);
            }
            else
            {
                _joint2D.useMotor = Input.GetKey(KeyCode.LeftShift);
            }
        }
    }
}
