using UnityEngine;

namespace GMPR2512.Lesson08_Plunger
{
    public class Plunger : MonoBehaviour
    {
        [SerializeField] private Transform _plungerLowestPoint;
        [SerializeField] private Transform _plungerStopPoint;
        [SerializeField] private float _plungerVelocity = -5;
        [SerializeField] private float _plungerForce = 10;
        private Rigidbody2D _rb;
        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();  
        }
        void Update()
        {
            bool spacePressed = Input.GetKey(KeyCode.Space);
            bool spaceReleased = Input.GetKeyUp(KeyCode.Space);

            if (transform.position.y >= _plungerLowestPoint.position.y && spacePressed)
            {
                MovePlungerDown();
            }

            if (spaceReleased)
            {
                ReleasePlunger();
            }
        }

        private void MovePlungerDown()
        {
            float moveAmount = _plungerVelocity * Time.deltaTime;
            transform.Translate(0f, moveAmount, 0, Space.Self);
        }
        private void ReleasePlunger()
        {
            //change the rigidbody type to dynamic
            _rb.bodyType = RigidbodyType2D.Dynamic;

            //determine amount of force based on how far down the plunger is
            float distance = _plungerStopPoint.position.y - transform.position.y;
            Vector2 impulse = new Vector2(0, _plungerForce * distance);

            _rb.AddForce(impulse, ForceMode2D.Impulse);
        }
    }
}
