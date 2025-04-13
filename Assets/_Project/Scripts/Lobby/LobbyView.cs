using MimiSokoban.UI;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace MimiSokoban.Lobby
{
    public class LobbyView : UIViewBase
    {
        [SerializeField] private Button play;
        
        [Inject] protected LobbyPresenter presenter;

        private void Start()
        {
            play.onClick.AddListener(OnClickPlay);
        }

        private void OnClickPlay()
        {
            presenter.Play();
        }

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
