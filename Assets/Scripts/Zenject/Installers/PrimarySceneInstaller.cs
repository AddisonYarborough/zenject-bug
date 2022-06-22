using Zenject;

public class PrimarySceneInstaller : MonoInstaller<PrimarySceneInstaller>
{
    public override void InstallBindings() {
        Container.BindInterfacesAndSelfTo<SceneChanger>().AsSingle();
    }
}
