using UnityEngine;

namespace MimiSokoban.Application
{
    public class ExampleEntryState : EntrySubState
    {
        protected override void OnEnterSubState()
        {
            Debug.LogWarning("Example Entry State");
            ToNextState();
        }
    }
}