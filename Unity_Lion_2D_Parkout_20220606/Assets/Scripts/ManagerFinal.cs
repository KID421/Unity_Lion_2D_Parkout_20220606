using UnityEngine;
using TMPro;

namespace KID
{
    /// <summary>
    /// �޲z�����e��
    /// �L���P����
    /// </summary>
    public class ManagerFinal : MonoBehaviour
    {
        [SerializeField, Header("�e��")]
        private CanvasGroup groupFinal;
        [SerializeField, Header("�C���������D")]
        private TextMeshProUGUI textFinal;

        /// <summary>
        /// �H�J
        /// </summary>
        private void FadeIn()
        {
            // �z���׻��W
            groupFinal.alpha += 0.1f;

            // �p�G �z���� >= 1 �N�Ұʤ��ʻP�B�׮g�u
            if (groupFinal.alpha >= 1)
            {
                groupFinal.interactable = true;
                groupFinal.blocksRaycasts = true;
            }
        }
    }
}

