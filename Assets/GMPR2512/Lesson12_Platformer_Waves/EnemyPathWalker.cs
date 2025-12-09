using UnityEngine;

namespace GMPR2512.Lesson12_Platformer_Waves
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class EnemyPathWalker : MonoBehaviour
    {
        [SerializeField] private Transform[] _waypoints;
        [SerializeField] private float _moveSpeed = 3.0f, _groundCheckRadius = 0.1f;
        [SerializeField] private LayerMask _groundLayer;
        
        private Transform _groundCheck;
        private Rigidbody2D _rigidBody2D;
        private int _currentWaypointIndex = 0;

        void Awake()
        {
            _rigidBody2D = GetComponent<Rigidbody2D>();
            _groundCheck = transform.GetChild(0);
        }
        void FixedUpdate()
        {
            bool grounded = Physics2D.OverlapCircle(_groundCheck.position, _groundCheckRadius, _groundLayer);
            
            if(grounded && _waypoints != null && _waypoints.Length > 0)
            {
                float horizontalVelocity = _rigidBody2D.linearVelocityX;
                Transform target = _waypoints[_currentWaypointIndex];
                float deltaX = target.position.x - transform.position.x;
                float direction = Mathf.Sign(deltaX);
                
                horizontalVelocity = direction * _moveSpeed;

                //have we arrived at our target waypoint?
                if(Mathf.Abs(deltaX) < 0.1f)
                {
                    _currentWaypointIndex = _currentWaypointIndex + 1;
                    if(_currentWaypointIndex >= _waypoints.Length)
                    {
                        //make it jitter around the last waypoint
                        _currentWaypointIndex = _waypoints.Length - 1;
                    }
                }
                _rigidBody2D.linearVelocity = 
                        new Vector2(horizontalVelocity, _rigidBody2D.linearVelocityY);
            }
        }
    }
}
