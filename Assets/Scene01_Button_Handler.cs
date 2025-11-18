using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Scene01_Button_Handler : MonoBehaviour
{
    private Button _changeToScene02Button;
    private void OnEnable()
    {
        //get the root UI element
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        _changeToScene02Button = root.Q<Button>("ChangeToScene02Button");
        if (_changeToScene02Button != null)
        {
            _changeToScene02Button.clicked += ChangeToScene02;
        }
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
        Debug.Log("BUTTON CLICKED");
    }
}
