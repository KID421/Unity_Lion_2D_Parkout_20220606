using UnityEngine;

namespace KID
{
    /// <summary>
    /// API �R�A���ϥΤ覡
    /// </summary>
    public class APIStatic : MonoBehaviour
    {
        private void Start()
        {
            #region �ǲ�
            // ���o�R�A�ݩ� get
            // �y�k�G
            // ���O.�R�A�ݩʦW��
            print("�H���ȡG" + Random.value);
            print("PI�G" + Mathf.PI);
            print("�L���j�G" + Mathf.Infinity);

            // �]�w�R�A�ݩ� set (Read Only ����ϥ�)
            // �y�k�G
            // ���O.�R�A�ݩʦW�� ���w �ȡF
            Cursor.visible = false;
            Physics2D.gravity = new Vector2(0, -9.8f);
            Time.timeScale = 10f;

            // �ϥ��R�A��k
            // �y�k�G
            // ���O.�R�A��k�W��(�����޼�)
            float range = Random.Range(20.5f, 100.5f);
            print("�H���d��G" + range);
            #endregion


        }

        private void Update()
        {
            #region �ǲ�
            int rangeInt = Random.Range(1, 3);
            print("�H����� 1 ~ 3�G" + rangeInt);
            #endregion


        }
    }
}
