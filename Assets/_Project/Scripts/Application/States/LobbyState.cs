using MimiSokoban.Loading;
using MimiSokoban.SceneLoader;
using Zenject;

namespace MimiSokoban.Application
{
    public class LobbyState : ApplicationStateBase
    {
        [Inject] private readonly SceneLoaderUsecase sceneLoaderUsecase;
        [Inject] private readonly LoadingPresenter loadingPresenter;
        
        protected override void OnEnterApplicationState()
        {
            sceneLoaderUsecase.OnFinish += OnLoadLobbyScene;
            sceneLoaderUsecase.LoadScene(SceneName.Lobby);
            loadingPresenter.Show();
        }

        private void OnLoadLobbyScene(string sceneName)
        {
            sceneLoaderUsecase.OnFinish -= OnLoadLobbyScene;
            loadingPresenter.Close();
        }
    }
}