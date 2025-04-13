using UnityEngine;

namespace MimiSokoban.Application
{
    public class ExampleEntrySubState : EntrySubState
    {
        protected override void OnEnterSubState()
        {
            Debug.LogWarning("Example Entry State");
            ToNextState();
        }
    }
}