using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class HelloWorldPopUpView : MonoBehaviour {
    /// <summary>
    /// Injected via <see cref="SecondarySceneInstaller"/>.
    /// </summary>
    [Inject] private HelloWorldPopUpController _controller = default;

    [SerializeField] private Button _button = default;

    public void Open() {
        _button.onClick.AddListener(OnButtonClick);
        gameObject.SetActive(true);
    }

    public void Close() {
        _button.onClick.RemoveListener(OnButtonClick);
        gameObject.SetActive(false);
    }

    private void OnButtonClick() {
        _controller.OnButtonClick();
    }
}
