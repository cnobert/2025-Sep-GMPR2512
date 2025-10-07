using UnityEngine;

namespace GMPR2512.Lesson08_Plunger
{
    public class PlungerStop : MonoBehaviour
    {
        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.gameObject.name == "Plunger")
            {
                collision.gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
            }
        }
    }
}
