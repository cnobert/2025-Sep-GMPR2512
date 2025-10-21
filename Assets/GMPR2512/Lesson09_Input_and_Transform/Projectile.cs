using UnityEngine;

namespace Lesson09_Input_and_Transform
{
    public class Projectile : MonoBehaviour
    {
        private float _speed;// = 10;
        private Vector2 _direction;// = Vector2.up;

        void Update()
        {
            transform.Translate(_direction.normalized * _speed * Time.deltaTime, Space.Self);
        }
        public void Initialize(Vector2 direction, float speed)
        {
            _direction = direction;
            _speed = speed;
        }

    }
}
