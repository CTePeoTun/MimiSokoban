using System;
using MimiSokoban.UI;

namespace MimiSokoban.Loading
{
    public class LoadingPresenterShowHandler : ShowViewHandler<LoadingView>, IDisposable
    {
        private readonly LoadingPresenter loadingPresenter;
        
        public LoadingPresenterShowHandler(LoadingPresenter loadingPresenter)
        {
            this.loadingPresenter = loadingPresenter;

            loadingPresenter.OnShow += Show;
        }
        
        public void Dispose()
        {
            loadingPresenter.OnShow -= Show;
        }
    }
}
