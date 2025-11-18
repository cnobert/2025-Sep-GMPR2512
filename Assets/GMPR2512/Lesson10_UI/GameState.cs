using UnityEngine;

namespace Lesson10_UI
{
    [CreateAssetMenu(menuName = "Game State")]
    public class GameState : ScriptableObject
    {
        public enum GamePlayState
        {
            NewGame,
            Level01Lost,
            Level01Win,
            Level02Lost,
            Level02Won
        }
        public GamePlayState _gamePlayState = GamePlayState.NewGame;

        public string startMenuGreeting = "Welcome, from the game state ScriptableObject";
        public int _scoreLevel01 = 0, _scoreLevel02 = 0, _numAliensLevel01, _numAliensLevel02;
    }
}
