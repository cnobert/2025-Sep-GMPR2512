using UnityEngine;

namespace GMPR2512.Lesson12_Platformer_Waves
{
    public class GameState : ScriptableObject
    {
        private int _numCoinsInScene;
        private bool _targetDestinationReached = false;

        internal int NumCoinsInScene
        {
            get => _numCoinsInScene;
            set
            {
                _numCoinsInScene = value;
                CheckForWin();
            }
        }
        internal bool TargetDestinationReached
        {
            set
            {
                _targetDestinationReached = value;
                CheckForWin();
            }
        }

        private void CheckForWin()
        {
            if(_numCoinsInScene <= 0 && _targetDestinationReached)
            {
                //game over!!!
                //make the win text label visible
                Time.timeScale = 0f;
            }
        }      
    }
}