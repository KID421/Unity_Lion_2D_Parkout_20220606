using UnityEngine;
using UnityEngine.SceneManagement;  // 引用場景管理 API
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
        /// 遊戲結束標題的文字內容
        /// </summary>
        public string stringTitle;

        private void Start()
        {
            textFinal.text = stringTitle;

            // MonoBehaviour 類別 API 可以直接使用名稱呼叫
            InvokeRepeating("FadeIn", 0, 0.1f);
        }

        /// <summary>
        /// 淡入
        /// </summary>
        private void FadeIn()
        {
            // 透明度遞增
            groupFinal.alpha += 0.1f;

            // print("淡入~");

            // 如果 透明度 >= 1 就啟動互動與遮擋射線
            if (groupFinal.alpha >= 1)
            {
                groupFinal.interactable = true;
                groupFinal.blocksRaycasts = true;

                CancelInvoke("FadeIn");
            }
        }

        // 按鈕與程式溝通方式
        // 1. 定義公開方法
        // 2. Button On Click 設定此腳本的公開方法
        /// <summary>
        /// 離開遊戲
        /// </summary>
        public void Quit()
        {
            // print("離開遊戲");
            // 只在發布執行檔 電腦與手機裝置上有作用
            Application.Quit();
        }

        /// <summary>
        /// 重新遊戲
        /// </summary>
        public void Replay()
        {
            SceneManager.LoadScene("遊戲場景");
        }
    }
}

