using UnityEngine;
using UnityEngine.SceneManagement;

namespace MimiSokoban.SceneLoader
{
    public class SceneLoaderGateway : ISceneLoaderGateway
    {
        public AsyncOperation LoadSceneAsync(string sceneName)
            => SceneManager.LoadSceneAsync(sceneName);
    }
    
    public interface ISceneLoaderGateway
    {
        AsyncOperation LoadSceneAsync(string sceneName);
    }
}