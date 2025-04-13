using MimiSokoban.Lobby;
using Zenject;

namespace MimiSokoban
{
    public class LobbyInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<LobbyPresenter>().AsSingle();
            
            Container.BindInterfacesAndSelfTo<LobbyShowHandler>().AsSingle().NonLazy();
        }
    }
}
