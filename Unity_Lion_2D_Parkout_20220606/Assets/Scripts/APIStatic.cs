using UnityEngine;

namespace KID
{
    /// <summary>
    /// API 靜態的使用方式
    /// </summary>
    public class APIStatic : MonoBehaviour
    {
        private void Start()
        {
            #region 學習
            // 取得靜態屬性 get
            // 語法：
            // 類別.靜態屬性名稱
            print("隨機值：" + Random.value);
            print("PI：" + Mathf.PI);
            print("無限大：" + Mathf.Infinity);

            // 設定靜態屬性 set (Read Only 不能使用)
            // 語法：
            // 類別.靜態屬性名稱 指定 值；
            Cursor.visible = false;
            Physics2D.gravity = new Vector2(0, -9.8f);
            Time.timeScale = 10f;

            // 使用靜態方法
            // 語法：
            // 類別.靜態方法名稱(對應引數)
            float range = Random.Range(20.5f, 100.5f);
            print("隨機範圍：" + range);
            #endregion


        }

        private void Update()
        {
            #region 學習
            int rangeInt = Random.Range(1, 3);
            print("隨機整數 1 ~ 3：" + rangeInt);
            #endregion


        }
    }
}
