using UnityEngine;
using Zenject;

public class HelloWorldPopUpController : IInitializable {
    /// <summary>
    /// Injected via <see cref="ProjectInstaller"/>.
    /// </summary>
    [Inject] private Transform _popupParent = default;

    private HelloWorldPopUpView _view = default;

    void IInitializable.Initialize() {
        GetPopUpView().Open();
    }

    private HelloWorldPopUpView GetPopUpView() {
        if (_view == null) {
            // The name of the prefab is the same name as the class name for simplicity
            const string prefabPath = nameof(HelloWorldPopUpView);

            // Load the object from Resources folder and instantiate it
            _view = Object.Instantiate(Resources.Load<HelloWorldPopUpView>(prefabPath), _popupParent);
        }

        return _view;
    }

    public void OnButtonClick() {
        Debug.Log($"[{nameof(HelloWorldPopUpController)}]: {nameof(HelloWorldPopUpView)} was clicked!");
    }
}
