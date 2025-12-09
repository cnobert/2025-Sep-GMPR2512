using UnityEngine;

namespace GMPR2512.Lesson11_Platformer
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
