using UnityEngine;

namespace KID
{
    /// <summary>
    /// 跳躍系統
    /// </summary>
    public class SystemJump : MonoBehaviour
    {
        #region 資料
        [SerializeField, Header("跳躍高度"), Range(0, 3000)]
        private float heightJump = 350;

        private Animator ani;
        private Rigidbody2D rig;
        private bool clickJump;
        #endregion

        #region 事件
        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

        // Input API 建議在 Update 呼叫
        // 一秒約 60 次
        private void Update()
        {
            JumpKey();
        }

        // 一秒固定 50 次
        private void FixedUpdate()
        {
            JumpForce();
        }
        #endregion

        #region 功能
        /// <summary>
        /// 跳躍按鍵
        /// </summary>
        private void JumpKey()
        {
            // 如果 玩家 按下 空白鍵 就往上 跳躍
            // if
            // switch
            // if 判斷式語法：if (布林值) { 布林值 為 true 執行程式 }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                print("跳躍~");
                clickJump = true;
            }
        }

        private void JumpForce()
        {
            if (clickJump)
            {
                rig.AddForce(new Vector2(0, heightJump));
                clickJump = false;
            }
        }
        #endregion
    }
}
