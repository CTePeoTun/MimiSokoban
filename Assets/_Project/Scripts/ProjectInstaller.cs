using MimiSokoban.Application;
using MimiSokoban.SceneLoader;
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
        }
    }
}
