using UnityEngine;

namespace GMPR2512.Lesson12_Platformer_Waves
{
    public class TargetDestination : MonoBehaviour
    {
        [SerializeField] private GameStateBootstrap _bootstrap;
        private GameState _gameState;
        private void Start()
        {

            _gameState = _bootstrap.TheGameState;
        }
        void OnTriggerEnter2D(Collider2D collision)
        {
            _gameState.TargetDestinationReached = true;
            Destroy(this.gameObject);
        }
    }
}
