using UnityEngine;
using UnityHFSM;
using Zenject;

namespace MimiSokoban.Application
{
    public class ApplicationStateMachine : StateMachine<ApplicationStateId, ApplicationTriggerTransitionId>, IInitializable
    {
        public ApplicationStateMachine(EntryState entryState, LobbyState lobbyState, PlayroomState playroomState)
        {
            SetStartState(ApplicationStateId.Entry);
            
            AddState(ApplicationStateId.Entry, entryState);
            this.AddTransition(ApplicationStateId.Entry, ApplicationStateId.Lobby);
            this.AddTriggerTransition(ApplicationTriggerTransitionId.ToLobby,
                ApplicationStateId.Entry,
                ApplicationStateId.Lobby);
            
            AddState(ApplicationStateId.Lobby, lobbyState);
            this.AddTransition(ApplicationStateId.Lobby, ApplicationStateId.Playroom);
            this.AddTriggerTransition(ApplicationTriggerTransitionId.ToPlayroom,
                ApplicationStateId.Lobby,
                ApplicationStateId.Playroom);
            
            AddState(ApplicationStateId.Playroom, playroomState);
            this.AddTransition(ApplicationStateId.Playroom, ApplicationStateId.Lobby);
            this.AddTriggerTransition(ApplicationTriggerTransitionId.ToLobby,
                ApplicationStateId.Playroom,
                ApplicationStateId.Lobby);
        }

        public void Initialize()
            => Init();
    }
}
