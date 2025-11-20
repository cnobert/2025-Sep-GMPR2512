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

        private GamePlayState _gamePlayState = GamePlayState.NewGame;
        public GamePlayState CurrentGameState
        {
            get => _gamePlayState;
            set => _gamePlayState = value;
        }
        public string StartMenuMessage
        { 
            get
            {
                string theMessage = "";
                Debug.Log(_gamePlayState);
                if (_gamePlayState == GamePlayState.NewGame)
                {
                    theMessage = "Welcome to this new game.";
                }
                else if (_gamePlayState == GamePlayState.Level01Lost)
                {
                    theMessage = "You allowed the alien invaders to take over the earth. Try again?";
                }
                return theMessage;
            }
        }

        public int _scoreLevel01 = 0, _scoreLevel02 = 0, _numAliensLevel01, _numAliensLevel02;

        private void ResetState()
        {
            _gamePlayState = GamePlayState.NewGame;
            _scoreLevel01 = 0;
            _scoreLevel02 = 0;
            _numAliensLevel01 = 0;
            _numAliensLevel02 = 0;
        }

        private void OnEnable()
        {
            ResetState();
        }

        private void OnDisable()
        {
            ResetState();
        }
    }
}