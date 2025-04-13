using MimiSokoban.Application;
using MimiSokoban.UI;
using Zenject;

namespace MimiSokoban.Lobby
{
    public sealed class LobbyPresenter : UIPresenter
    {
        [Inject] private readonly ApplicationUsecase applicationUsecase;
        public void Play()
        {
            Close();
            applicationUsecase.ToPlayroom();
        }
    }
}