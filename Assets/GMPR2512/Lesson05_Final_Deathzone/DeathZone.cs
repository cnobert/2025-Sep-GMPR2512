
using UnityEngine;

namespace GMPR2512.Lesson05_Final_Deathzone
{
    public class DeathZone : MonoBehaviour
    {
        void Awake()
        {

        }
        void Start()
        {
        }

        void Update()
        {

        }
        /*
            If at least one of two game objects has a Rigidbody2D, and they both have Collider2Ds, 
            when they collide the following three methods will be executed, if they exist, on both game ojects:
            OnCollisionEnter2D
            OnCollisionStay2D
            OnCollisionExit2D
        */
        void OnCollisionEnter2D(Collision2D collision)
        {
            Debug.Log("KAPPPPOWWWWW!");
            //collision.collider represents the collider of the game object that bumped into us
            //collision.otherCollider represenst the collider of the game object
            //to which this script is attached

            //what if we only want to destroy it if it's a ball?
            //we can give the ball at "tag"
            if (collision.collider.CompareTag("Ball"))
            {
                Destroy(collision.gameObject);
            }
        }

    }
}
