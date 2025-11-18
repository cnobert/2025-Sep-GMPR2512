using UnityEngine;

namespace Lesson10_UI
{
    public class Circle : MonoBehaviour
    {
        [SerializeField] private GameState _gameState;

        void OnCollisionEnter2D(Collision2D collision)
        {
            _gameState._scoreLevel01++;
        }
    }
}
