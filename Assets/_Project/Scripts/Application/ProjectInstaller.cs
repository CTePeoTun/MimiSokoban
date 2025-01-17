using Zenject;

namespace MimiSokoban
{
    public class ProjectInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<CoroutineRunner>().FromNewComponentOnNewGameObject().AsSingle();
        }
    }
}
