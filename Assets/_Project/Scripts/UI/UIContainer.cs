using MimiSokoban.Utils;
using UnityEngine;
using Zenject;

namespace MimiSokoban.UI
{
    public class UIContainer : MonoBehaviour
    {
        private const string ViewsPathFormat = "UIViews/{0}";

        [Inject] private readonly DiContainer diContainer;
        
        public void Show<T>() where T : UIViewBase
        {
            var type = typeof(T);
            try
            {
                var path = string.Format(ViewsPathFormat, type.Name);
                var prefab = Resources.Load<T>(path);
                var container = diContainer.SceneOrProjectContainer();
                container.InstantiatePrefabForComponent<T>(prefab, transform);
            }
            catch
            {
                Debug.LogError($"{this} unable create view='{type.Name}'");
                throw;
            }
        }
    }
}