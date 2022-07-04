using UnityEngine;
using TMPro;

namespace KID
{
    /// <summary>
    /// 管理結束畫面
    /// 過關與失敗
    /// </summary>
    public class ManagerFinal : MonoBehaviour
    {
        [SerializeField, Header("畫布")]
        private CanvasGroup groupFinal;
        [SerializeField, Header("遊戲結束標題")]
        private TextMeshProUGUI textFinal;

        /// <summary>
        /// 淡入
        /// </summary>
        private void FadeIn()
        {
            // 透明度遞增
            groupFinal.alpha += 0.1f;

            // 如果 透明度 >= 1 就啟動互動與遮擋射線
            if (groupFinal.alpha >= 1)
            {
                groupFinal.interactable = true;
                groupFinal.blocksRaycasts = true;
            }
        }
    }
}

