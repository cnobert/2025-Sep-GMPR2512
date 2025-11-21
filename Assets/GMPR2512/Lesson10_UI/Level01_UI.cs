using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

namespace Lesson10_UI
{
    public class Level01_UI : MonoBehaviour
    {
        [SerializeField] private GameState _gameState;
        private Label _scoreLabel;

        private float _delaySeconds = 5.0f;
        private float _timer;

        private void Awake()
        {
            _timer = 0f;
        }

        private void OnEnable()
        {
            VisualElement uiDoc = GetComponent<UIDocument>().rootVisualElement;
            _scoreLabel = uiDoc.Q<Label>("scoreLabel");
        }

        private void Update()
        {
            _scoreLabel.text = _gameState._scoreLevel01.ToString();

            _timer += Time.deltaTime;
            if (_timer >= _delaySeconds)
            {
                TestLoadMenu();
            }
        }

        private void TestLoadMenu()
        {
            
            SceneManager.LoadScene("Lesson10_UI");
        }
    }
}