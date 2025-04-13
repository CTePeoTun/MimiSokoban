using System;
using MimiSokoban.SceneLoader;
using MimiSokoban.UI;

namespace MimiSokoban.Lobby
{
    public class LobbyShowHandler : ShowViewHandler<LobbyView>, IDisposable
    {
        private readonly LobbyPresenter lobbyPresenter;
        private readonly SceneLoaderUsecase sceneLoaderUsecase;
        
        public LobbyShowHandler(LobbyPresenter lobbyPresenter, SceneLoaderUsecase sceneLoaderUsecase)
        {
            this.lobbyPresenter = lobbyPresenter;
            this.sceneLoaderUsecase = sceneLoaderUsecase;

            lobbyPresenter.OnShow += Show;
            sceneLoaderUsecase.OnFinish += OnLoadScene;
        }

        public void Dispose()
        {
            lobbyPresenter.OnShow -= Show;
            sceneLoaderUsecase.OnFinish -= OnLoadScene;
        }

        private void OnLoadScene(string sceneName)
        {
            if (sceneName != SceneName.Lobby)
                return;
            
            Show();
        }
    }
}
