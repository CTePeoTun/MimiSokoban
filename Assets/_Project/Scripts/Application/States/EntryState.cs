using UnityEngine;
using UnityHFSM;
using Zenject;

namespace MimiSokoban.Application
{
    public class EntryState : StateMachine<ApplicationStateId, int, int>
    {
        public EntryState(LazyInject<ApplicationStateMachine> injectAppStateMachine,
            EntrySubState[] entrySubStates)
        {
            if (entrySubStates.Length == 0)
                Debug.LogWarning("EntrySubStates is empty.");
            
            for (int i = 0; i < entrySubStates.Length; i++)
                AddState(i, entrySubStates[i]);
            
            AddState(entrySubStates.Length, new State<int, int>(onEnter: OnFinishAllEntrySubStates));
            
            for (int i = 0; i < entrySubStates.Length; i++)
                AddTriggerTransition(i, new Transition<int>(i, i + 1));
            
            return;
            
            void OnFinishAllEntrySubStates(State<int, int> state)
                => injectAppStateMachine.Value.OnLogic();
        }

        public override void OnEnter()
        {
            Debug.Log($"On enter application state {GetType().Name}");
            base.OnEnter();
        }

        //Need override when not have transition for exit
        public override void OnExit() { }
    }
}