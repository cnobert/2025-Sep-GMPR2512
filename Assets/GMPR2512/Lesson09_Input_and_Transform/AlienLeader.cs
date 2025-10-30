using UnityEngine;

namespace Lesson09_Input_and_Transform
{
    public class AlienLeader : MonoBehaviour
    {
        [SerializeField] private float _movementSpeed = 5;
        private Vector2 _direction = new Vector2(1, 0);

        void Update()
        {
            Vector2 translation = _direction.normalized * _movementSpeed * Time.deltaTime;
            transform.Translate(translation, Space.World);
        }
        internal void ChangeHorizontalDirection()
        {
            _direction *= -1;
        }
    }
}
