using UnityEngine;

namespace MimiSokoban.UI
{
    public abstract class UIViewBase : MonoBehaviour
    {
        protected void Close()
        {
            Destroy(gameObject);
        }
    }
}