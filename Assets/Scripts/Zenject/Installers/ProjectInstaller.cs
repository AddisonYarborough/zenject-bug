using UnityEngine;
using Zenject;

public class ProjectInstaller : MonoInstaller<ProjectInstaller> {
    [SerializeField] private Transform _popupParent = default;

    public override void InstallBindings() {
        Container.Bind<Transform>().FromInstance(_popupParent).AsSingle();
    }
}
