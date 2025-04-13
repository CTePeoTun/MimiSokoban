using Zenject;

namespace MimiSokoban.Loading
{
    public class LoadingInstaller : Installer
    {
        public override void InstallBindings()
        {
            Container.Bind<LoadingPresenter>().AsSingle();
            Container.Bind<LoadingPresenterShowHandler>().AsSingle().NonLazy();
        }
    }
}
