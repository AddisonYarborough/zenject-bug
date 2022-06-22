using Zenject;

public class SecondarySceneInstaller : MonoInstaller
{
    public override void InstallBindings() {
        Container.BindInterfacesAndSelfTo<HelloWorldPopUpController>().AsSingle();
    }
}
