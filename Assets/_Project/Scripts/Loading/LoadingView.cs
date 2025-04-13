using MimiSokoban.UI;
using Zenject;

namespace MimiSokoban.Loading
{
    public class LoadingView : UIViewBase
    {
        [Inject] protected LoadingPresenter presenter;

        private void OnEnable()
        {
            presenter.OnClose += Close;
        }
        
        private void OnDisable()
        {
            presenter.OnClose -= Close;
        }
    }
}
