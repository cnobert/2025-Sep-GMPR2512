using UnityEngine;

namespace GMPR2512.Lesson12_Platformer_Waves
{
    public class GameStateBootstrap : MonoBehaviour
    {
        public GameState TheGameState { get; private set; }

        private void Awake()
        {
            TheGameState = ScriptableObject.CreateInstance<GameState>();
        }
    }
}
