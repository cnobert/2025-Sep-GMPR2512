using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

namespace Lesson10_UI
{
    public class Level01_UI : MonoBehaviour
    {
        [SerializeField] private GameState _gameState;
        private Label _scoreLabel;

        private float _delaySeconds = 2.0f;
        private float _timer;
        private bool _menuLoaded;

        private void Awake()
        {
            _timer = 0f;
            _menuLoaded = false;
        }

        private void OnEnable()
        {
            VisualElement uiDoc = GetComponent<UIDocument>().rootVisualElement;
            _scoreLabel = uiDoc.Q<Label>("scoreLabel");
        }

        private void Update()
        {
            _scoreLabel.text = _gameState._scoreLevel01.ToString();

            if (_menuLoaded == false)
            {
                _timer += Time.deltaTime;
                if (_timer >= _delaySeconds)
                {
                    _menuLoaded = true;
                    TestLoadMenu();
                }
            }
        }

        private void TestLoadMenu()
        {
            SceneManager.LoadScene("Lesson10_UI");
        }
    }
}