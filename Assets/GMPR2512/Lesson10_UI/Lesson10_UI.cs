using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

namespace Lesson10_UI
{
    public class Lesson10_UI : MonoBehaviour
    {
        [SerializeField] private GameState _gameState;
        private Button _changeToScene02Button;
        private Label _welcomeMessageLabel;

        private void OnEnable()
        {
            VisualElement uiDoc = GetComponent<UIDocument>().rootVisualElement;

            _changeToScene02Button = uiDoc.Q<Button>("ChangeToScene02Button");
            _welcomeMessageLabel = uiDoc.Q<Label>("LabelWelcome");


            _welcomeMessageLabel.text = _gameState.StartMenuMessage;

            if (_changeToScene02Button != null)
            {
                _changeToScene02Button.clicked += ChangeToScene02;
            }
        }

        private void Update()
        {
            //we will check for data changes and display them in the label here


            //check _gameState._numAliensLevel01 to see if it has reached 0
            //if so, load level 02
            //for this to work, Aliens or Projectiles have to update _numAliensLevel01 
            //when an Alien gets destroyed
        }

        private void OnDisable()
        {
            if (_changeToScene02Button != null)
            {
                _changeToScene02Button.clicked -= ChangeToScene02;
            }
        }
        private void ChangeToScene02()
        {
            _gameState.CurrentGameState = GameState.GamePlayState.Level01Lost;
            SceneManager.LoadScene("Level01");
        }
    }
}