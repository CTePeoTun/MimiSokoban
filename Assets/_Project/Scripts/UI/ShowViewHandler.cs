using Zenject;

namespace MimiSokoban.UI
{
    public abstract class ShowViewHandler<T> where T : UIViewBase
    {
        [Inject] private readonly UIContainer uiContainer;

        protected void Show()
            => uiContainer.Show<T>();
    }
}