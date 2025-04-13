using UnityEngine.EventSystems;
using Zenject;

namespace MimiSokoban.UI
{
    public class UIInstaller : Installer
    {
        public override void InstallBindings()
        {
            Container.Bind<UIContainer>()
                .FromComponentInNewPrefabResource(nameof(UIContainer))
                .WithGameObjectName(nameof(UIContainer))
                .AsSingle()
                .NonLazy();
            
            Container.Bind<EventSystem>()
                .FromComponentInNewPrefabResource(nameof(EventSystem))
                .WithGameObjectName(nameof(EventSystem))
                .AsSingle()
                .NonLazy();
        }
    }
}
