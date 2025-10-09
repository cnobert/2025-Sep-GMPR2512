using UnityEngine;

namespace GMPR2512.Lesson08_Plunger
{
    public class PlungerStop : MonoBehaviour
    {
        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.gameObject.name == "Plunger")
            {
                //to get the gameObject that this script is attached to, use "gameObject"
                //to get the gameObject that we just collided with, use collision.gameObject
                collision.rigidbody.bodyType = RigidbodyType2D.Kinematic;
                //collision.gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
            }
        }
    }
}
