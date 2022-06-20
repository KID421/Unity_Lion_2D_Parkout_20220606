using UnityEngine;

namespace KID
{
    /// <summary>
    /// 非靜態 API
    /// 與靜態的差別在於需要一個「實體物件」
    /// 「實體物件」一個存在於場景上的遊戲物件 Game Object
    /// </summary>
    public class APINonStatic : MonoBehaviour
    {
        // 1. 定義欄位，資料類型為類別
        // 2. Unity 屬性面板必須確定該欄位不是空值 None
        // 3. 使用非靜態 API
        [SerializeField]
        private GameObject turtle;
        [SerializeField]
        private Transform startPoint;

        private void Start()
        {
            // 1. 取得 非靜態屬性
            // 語法：欄位名稱.非靜態屬性
            print("忍者龜的啟動狀態：" + turtle.activeInHierarchy);
            print("忍者龜預設圖層：" + turtle.layer);
            print("起點的座標：" + startPoint.position);

            // 2. 設定 非靜態屬性
            // 語法：欄位名稱.非靜態屬性 指定 值；
            // turtle.activeInHierarchy = false; (錯誤，唯讀屬性 官方沒寫)
            turtle.tag = "Player";
            turtle.layer = 4;
            startPoint.position = new Vector3(0, 5, 0);

            // 3. 使用 非靜態方法
            // 語法：欄位名稱.非靜態方法(對應的引數)；
            turtle.SetActive(false);
        }

        private void Update()
        {
            startPoint.Translate(0.5f, 0, 0);
            startPoint.Rotate(0, 0, 3.5f);
        }
    }
}
