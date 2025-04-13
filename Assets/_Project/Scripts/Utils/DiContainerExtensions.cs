using Zenject;

namespace MimiSokoban.Utils
{
    public static class DiContainerExtensions
    {
        public static DiContainer SceneOrProjectContainer(this DiContainer container)
        {
            var sceneContextRegistry = container.TryResolve<SceneContextRegistry>();
            if (sceneContextRegistry == null)
                return container;
            
            var sceneContexts = sceneContextRegistry.SceneContexts;
            foreach (var sceneContext in sceneContexts)
                return sceneContext.Container;

            return container;
        }
    }
}
