using System;

namespace MimiSokoban.UI
{
    public class UIPresenter
    {
        public event Action OnShow;
        public event Action OnClose;

        public virtual void Show()
            => OnShow?.Invoke();

        public virtual void Close()
            => OnClose?.Invoke();
    }
}