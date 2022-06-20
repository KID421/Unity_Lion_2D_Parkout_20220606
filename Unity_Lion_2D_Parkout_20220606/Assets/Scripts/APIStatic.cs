using UnityEngine;

namespace KID
{
    /// <summary>
    /// API 靜態的使用方式
    /// </summary>
    public class APIStatic : MonoBehaviour
    {
        private Vector3 a = new Vector3(1, 1, 1);
        private Vector3 b = new Vector3(22, 22, 22);

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

            // 類別名稱.靜態屬性名稱
            print("所有攝影機數量：" + Camera.allCamerasCount);
            print("目前的平台：" + Application.platform);

            Physics.sleepThreshold = 10;
            print("睡眠臨界值：" + Physics.sleepThreshold);
            Time.timeScale = 0.5f;
            print("時間大小：" + Time.timeScale);

            // 類別名稱.靜態方法名稱(對應的引數)
            print("9.999 去掉小數點四捨五入：" + Mathf.Round(9.999f));

            float distance = Vector3.Distance(a, b);
            print("<color=yellow>距離：" + distance + "</color>");

            Application.OpenURL("https://unity.com/");
        }

        private void Update()
        {
            #region 學習
            int rangeInt = Random.Range(1, 3);
            print("隨機整數 1 ~ 3：" + rangeInt);
            #endregion

            // print("是否按下任意鍵：" + Input.anyKeyDown);
            // print("遊戲經過時間：" + Time.timeSinceLevelLoad);

            print("<color=red>是否按下空白鍵：" + Input.GetKeyDown(KeyCode.Space) + "</color>");
        }
    }
}
