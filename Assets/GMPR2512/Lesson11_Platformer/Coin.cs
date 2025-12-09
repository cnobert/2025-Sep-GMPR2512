using UnityEngine;

namespace GMPR2512.Lesson11_Platformer
{
    public class Coin : MonoBehaviour
    {
        //drag bootstrap game object to this slot in Unity Editor
        [SerializeField] private GameStateBootstrap _bootstrap; 
        private GameState _gameState;

        private SoundHub _soundHub;

        void Start()
        {
            _soundHub = GameObject.Find("SoundHub").GetComponent<SoundHub>();
            _gameState = _bootstrap.TheGameState;
            _gameState.NumCoinsInScene++;
        }
        void OnTriggerEnter2D(Collider2D collision)
        {
            _soundHub.PlayCoinSound();
            _gameState.NumCoinsInScene--;
            Destroy(this.gameObject);
        }
    }
}
