using UnityEngine;

namespace KID
{
    /// <summary>
    /// API �R�A���ϥΤ覡
    /// </summary>
    public class APIStatic : MonoBehaviour
    {
        private Vector3 a = new Vector3(1, 1, 1);
        private Vector3 b = new Vector3(22, 22, 22);

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

            // ���O�W��.�R�A�ݩʦW��
            print("�Ҧ���v���ƶq�G" + Camera.allCamerasCount);
            print("�ثe�����x�G" + Application.platform);

            Physics.sleepThreshold = 10;
            print("�ίv�{�ɭȡG" + Physics.sleepThreshold);
            Time.timeScale = 0.5f;
            print("�ɶ��j�p�G" + Time.timeScale);

            // ���O�W��.�R�A��k�W��(�������޼�)
            print("9.999 �h���p���I�|�ˤ��J�G" + Mathf.Round(9.999f));

            float distance = Vector3.Distance(a, b);
            print("<color=yellow>�Z���G" + distance + "</color>");

            Application.OpenURL("https://unity.com/");
        }

        private void Update()
        {
            #region �ǲ�
            int rangeInt = Random.Range(1, 3);
            print("�H����� 1 ~ 3�G" + rangeInt);
            #endregion

            // print("�O�_���U���N��G" + Input.anyKeyDown);
            // print("�C���g�L�ɶ��G" + Time.timeSinceLevelLoad);

            print("<color=red>�O�_���U�ť���G" + Input.GetKeyDown(KeyCode.Space) + "</color>");
        }
    }
}
