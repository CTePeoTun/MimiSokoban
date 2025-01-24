using Zenject;

namespace MimiSokoban.Application
{
    public class ApplicationInstaller : Installer
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<ApplicationStateMachine>().AsSingle();
            Container.Bind<EntryState>().AsSingle();
            Container.Bind<EntrySubState>().To<ExampleEntryState>().AsSingle();
            Container.Bind<LobbyState>().AsSingle();
            Container.Bind<PlayroomState>().AsSingle();
            Container.Bind<ApplicationPresenter>().AsSingle();
        }
    }
}
