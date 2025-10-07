using UnityEngine;

namespace GMPR2512.Lesson08_Plunger
{
    public class Plunger : MonoBehaviour
    {
        [SerializeField] private Transform _plungerLowestPoint;
        [SerializeField] private float _plungerVelocity = -5;
        void Update()
        {
            bool spacePressed = Input.GetKey(KeyCode.Space);
            if (transform.position.y >= _plungerLowestPoint.position.y && spacePressed)
            {
                MovePlungerDown();
            }
        }

        private void MovePlungerDown()
        {
            float moveAmount = _plungerVelocity * Time.deltaTime;
            transform.Translate(0f, moveAmount, 0, Space.Self);
        }
    }
}
