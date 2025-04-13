using UnityEngine;
using UnityHFSM;
using Zenject;

namespace MimiSokoban.Application
{
    public abstract class EntrySubState : StateBase<int>
    {
        [Inject] private readonly LazyInject<EntryState> entryState;
        
        protected EntrySubState() : base(false)
        {
        }
        
        public sealed override void OnEnter()
        {
            Debug.Log($"On Enter {GetType().Name}");
            OnEnterSubState();
        }

        protected abstract void OnEnterSubState();

        protected void ToNextState()
            => entryState.Value.Trigger(name);
    }
}