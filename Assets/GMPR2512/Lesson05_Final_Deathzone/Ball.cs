using UnityEngine;

namespace GMPR2512.Lesson05_Final_Deathzone
{
    public class Ball : MonoBehaviour
    {
        private Rigidbody2D _rb;
        private void Awake()
        {
            //The GetComponent method is expensive, so we don't want to call it every update. 
            //Therefore, we get a reference to the component in Awake, and store it as a data member.
            _rb = GetComponent<Rigidbody2D>();
            if (_rb == null)
            {
                Debug.LogError("Ball class requires a Rigidbody2D on the same GameObject.");
            }
        }
        void Update()
        {

        }
        void OnCollisionEnter2D(Collision2D collision)
        {
            string nameOfObjectIBumpedInto = collision.collider.name;
            
            Debug.Log($"Ball collided with {nameOfObjectIBumpedInto}");
        }
    }
}
