using Scripts.Data;
using UnityEngine;

namespace Scripts
{
    public class QuitApplication : MonoBehaviour
    {
        public void QuitAplication()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
        }
    }
}
