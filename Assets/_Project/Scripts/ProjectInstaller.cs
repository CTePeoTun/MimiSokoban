using MimiSokoban.Application;
using MimiSokoban.Loading;
using MimiSokoban.SceneLoader;
using MimiSokoban.UI;
using Zenject;

namespace MimiSokoban
{
    public class ProjectInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<CoroutineRunner>().FromNewComponentOnNewGameObject().AsSingle();
            
            Container.Install<ApplicationInstaller>();
            Container.Install<SceneLoaderInstaller>();
            Container.Install<UIInstaller>();
            Container.Install<LoadingInstaller>();
        }
    }
}
