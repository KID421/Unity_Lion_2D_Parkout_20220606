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
        [SerializeField, Header("檢查地板尺寸")]
        private Vector3 v3CheckGroundSize = Vector3.one;
        [SerializeField, Header("檢查地板位移")]
        private Vector3 v3CheckGroundOffset;
        [SerializeField, Header("檢查地板顏色")]
        private Color colorCheckGround = new Color(1, 0, 0.2f, 0.5f);
        [SerializeField, Header("檢查地板圖層")]
        private LayerMask layerCheckGround;

        private Animator ani;
        private Rigidbody2D rig;
        private bool clickJump;
        private bool isGround;
        #endregion

        #region 事件
        // 繪製圖示
        // 在編輯器內繪製輔助用的線條、形狀或圖片：遊戲內不會出現
        private void OnDrawGizmos()
        {
            // 1. 決定顏色
            Gizmos.color = colorCheckGround;
            // 2. 繪製圖示
            // transform.position 當前物件的座標
            Gizmos.DrawCube(transform.position + v3CheckGroundOffset, v3CheckGroundSize);
        }

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
            CheckGround();
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
                // print("跳躍~");
                clickJump = true;
            }
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                clickJump = false;
            }
        }

        /// <summary>
        /// 跳躍推力
        /// </summary>
        private void JumpForce()
        {
            // 如果 點擊跳躍 並且 && 在地板上
            if (clickJump && isGround)
            {
                rig.AddForce(new Vector2(0, heightJump));
                clickJump = false;
            }
        }

        /// <summary>
        /// 檢查是否碰到地板
        /// </summary>
        private void CheckGround()
        {
            // 2D 碰撞器 = 2D 物理.覆蓋盒型區域(中心點，尺寸，角度，圖層)；
            Collider2D hit = Physics2D.OverlapBox(transform.position + v3CheckGroundOffset, v3CheckGroundSize, 0, layerCheckGround);
            // print("碰到的物件：" + hit.name);

            isGround = hit;
        }
        #endregion
    }
}
