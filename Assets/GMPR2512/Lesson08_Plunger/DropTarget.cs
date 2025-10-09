using UnityEngine;

namespace GMPR2512.Lesson08_Plunger
{
    public class DropTarget : MonoBehaviour
    {
        [SerializeField] private Color _hitColour = Color.yellow;
        [SerializeField] private float _hideDelay = 0.1f;
        [SerializeField] private float _resetDelay = 2f;

        private bool _isDown = false;
        private SpriteRenderer _renderer;
        private Color _originalColour;

        void Awake()
        {
            _renderer = GetComponent<SpriteRenderer>();
            _originalColour = _renderer.color;
        }

        void OnCollisionEnter2D(Collision2D collision)
        {
            if (!_isDown && collision.collider.CompareTag("Ball"))
            {
                _isDown = true;
                _renderer.color = _hitColour;
                Invoke(nameof(HideTarget), _hideDelay);//call the named method in 1 second
            }
        }

        void HideTarget()
        {
            gameObject.SetActive(false);
            Invoke(nameof(ResetTarget), _resetDelay);
        }
        void ResetTarget()
        {
            _renderer.color = _originalColour;
            gameObject.SetActive(true);
            _isDown = false;
        }
    }
}
