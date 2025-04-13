using Zenject;

namespace MimiSokoban.SceneLoader
{
    public class SceneLoaderInstaller : Installer
    {
        public override void InstallBindings()
        {
            Container.Bind<ISceneLoaderGateway>().To<SceneLoaderGateway>().AsSingle();
            Container.Bind<SceneLoaderUsecase>().AsSingle();
        }
    }
}
