using System;
using System.Collections;
using UnityEngine;
using Zenject;

namespace MimiSokoban.SceneLoader
{
    public class SceneLoaderUsecase
    {
        public event Action<string> OnStart;
        public event Action<float> OnProgress;
        public event Action<string> OnFinish;
        
        [Inject] private readonly ISceneLoaderGateway sceneLoaderGateway;
        [Inject] private readonly CoroutineRunner coroutineRunner;
        
        public void LoadScene(string sceneName)
            => coroutineRunner.StartCoroutine(LoadSceneRoutine(sceneName));

        private IEnumerator LoadSceneRoutine(string sceneName)
        {
            Debug.Log($"Start load scene {sceneName}");
            OnStart?.Invoke(sceneName);
            var loadSceneOperation = sceneLoaderGateway.LoadSceneAsync(sceneName);
            while (!loadSceneOperation.isDone)
            {
                OnProgress?.Invoke(loadSceneOperation.progress);
                yield return null;
            }
            Debug.Log($"Finish load scene {sceneName}");
            OnFinish?.Invoke(sceneName);
        }
    }
}
