using MimiSokoban.Loading;
using MimiSokoban.SceneLoader;
using Zenject;

namespace MimiSokoban.Application
{
    public class PlayRoomState : ApplicationStateBase
    {
        [Inject] private readonly SceneLoaderUsecase sceneLoaderUsecase;
        [Inject] private readonly LoadingPresenter loadingPresenter;
        
        protected override void OnEnterApplicationState()
        {
            sceneLoaderUsecase.OnFinish += OnLoadPlayRoom;
            sceneLoaderUsecase.LoadScene(SceneName.PlayRoom);
            loadingPresenter.Show();
        }

        private void OnLoadPlayRoom(string sceneName)
        {
            sceneLoaderUsecase.OnFinish -= OnLoadPlayRoom;
            loadingPresenter.Close();
        }
    }
}