using TMPro;
using UnityEngine;
using UnityEngine.Localization.Components;

namespace JoninhasToolKit.Localization
{
    public class LocalizeDynamicHandler : MonoBehaviour
    {

        [SerializeField] LocalizeStringEvent m_event;

        public void UpdateArg<T>(T argument)
        {
            m_event.StringReference.Arguments = new object[] { argument };
            m_event.StringReference.Arguments[0] = argument;
            m_event.RefreshString();
        }

    }
}

