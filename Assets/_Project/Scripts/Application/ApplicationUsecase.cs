using Zenject;

namespace MimiSokoban.Application
{
    public class ApplicationUsecase
    {
        [Inject] private readonly ApplicationStateMachine applicationStateMachine;

        public void ToLobby()
            => applicationStateMachine.Trigger(ApplicationTriggerTransitionId.ToLobby);
        
        public void ToPlayroom()
            => applicationStateMachine.Trigger(ApplicationTriggerTransitionId.ToPlayroom);
    }
}