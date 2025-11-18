using UnityEngine;
using UnityEngine.UIElements;

namespace Lesson10_UI
{
    public class Level01_UI : MonoBehaviour
    {
        [SerializeField] private GameState _gameState;
        private Label _scoreLabel;
        private void OnEnable()
        {
            VisualElement uiDoc = GetComponent<UIDocument>().rootVisualElement;
            _scoreLabel = uiDoc.Q<Label>("scoreLabel");
        }
        void Update()
        {
            _scoreLabel.text = _gameState._scoreLevel01.ToString();;
        }
    }
}
