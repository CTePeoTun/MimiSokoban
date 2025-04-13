using MimiSokoban.SceneLoader;
using Zenject;

namespace MimiSokoban.Application
{
    public class LobbyState : ApplicationStateBase
    {
        [Inject] private readonly SceneLoaderUsecase sceneLoaderUsecase;
        
        protected override void OnEnterApplicationState()
        {
            sceneLoaderUsecase.OnFinish += OnLoadLobbyScene;
            sceneLoaderUsecase.LoadScene(SceneName.Lobby);
        }

        private void OnLoadLobbyScene(string sceneName)
        {
            sceneLoaderUsecase.OnFinish -= OnLoadLobbyScene;
        }
    }
}