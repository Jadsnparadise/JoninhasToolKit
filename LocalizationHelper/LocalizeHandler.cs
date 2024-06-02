using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;

namespace JoninhasToolKit.Localization
{
    public class LocalizeHandler : MonoBehaviour
    {

        [SerializeField] LocalizeStringEvent m_stringEvent;

        public void ChangeReference(LocalizedString m_Key)
        {
            m_stringEvent.StringReference = m_Key;
        }

    }
}

