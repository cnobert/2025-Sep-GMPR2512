using UnityEngine;

namespace Lesson09_Input_and_Transform
{
    public class Projectile : MonoBehaviour
    {
        private float _speed;// = 10;
        private Vector2 _direction;// = Vector2.up;
        private float _spinVelocity;

        void Update()
        {
            transform.Translate(_direction.normalized * _speed * Time.deltaTime, Space.World);
            transform.Rotate(Vector3.forward * _spinVelocity * Time.deltaTime, Space.World);
        }
        //pass spinSpeed == 0 if no spin wanted
        public void Initialize(Vector2 direction, float speed, float spinSpeed)
        {
            _direction = direction;
            _speed = speed;
            _spinVelocity = spinSpeed;
        }

    }
}
