using System.Collections;
using UnityEngine;

namespace GMPR2512.Lesson11_Platformer
{
    public class PlatformFalling : MonoBehaviour
    {
        private Renderer _myRenderer;
        private Rigidbody2D _myRigidbody2D;
        void Awake()
        {
            _myRenderer = GetComponent<Renderer>();
            _myRigidbody2D = GetComponent<Rigidbody2D>();
        }
        void OnCollisionEnter2D(Collision2D collision)
        {
            _myRenderer.material.color = Color.magenta;
            StartCoroutine("WaitThenFall");
        }
        IEnumerator WaitThenFall()
        {
            yield return new WaitForSeconds(2);
            _myRigidbody2D.bodyType = RigidbodyType2D.Dynamic;
        }
    }
}
