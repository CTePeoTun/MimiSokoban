using UnityEngine;
using UnityHFSM;

namespace MimiSokoban.Application
{
    public abstract class ApplicationStateBase : StateBase<ApplicationStateId>
    {
        protected ApplicationStateBase(bool needsExitTime = false, bool isGhostState = false) : base(needsExitTime,
            isGhostState)
        {
        }

        public sealed override void OnEnter()
        {
            Debug.Log($"On enter application state {GetType().Name}");
            OnEnterApplicationState();
        }

        protected abstract void OnEnterApplicationState();
    }
}