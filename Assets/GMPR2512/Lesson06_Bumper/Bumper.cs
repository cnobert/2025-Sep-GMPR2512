using System.Collections;
using UnityEngine;

namespace GMPR2512.Lesson06_Bumper
{
    public class Bumper : MonoBehaviour
    {
        [SerializeField] private float _bumperForce = 150;
        [SerializeField] private Color _litColor = Color.yellow;
        [SerializeField] private float _litDuration = 0.2f;

        private bool _isLit = false;
        private Color _originalColour;
        private SpriteRenderer _spriteRenderer;
        void Awake()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
            _originalColour = _spriteRenderer.color;
        }
        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.CompareTag("Ball"))
            {
                //Debug.Log($"A game object with the tag {collision.collider.tag} just hit me!!");
                if (collision.rigidbody != null)
                {
                    collision.rigidbody.AddForce(_bumperForce * collision.relativeVelocity);
                }
                //call coroutine that lights up the bumper and then after some time changes it back
                if (!_isLit)
                {
                    StartCoroutine(LightUp());
                }
            }
        }
        private IEnumerator LightUp()
        {
            _isLit = true;
            _spriteRenderer.color = _litColor;
            yield return new WaitForSeconds(_litDuration);
            _spriteRenderer.color = _originalColour;
            _isLit = false;
        }
    }
}
