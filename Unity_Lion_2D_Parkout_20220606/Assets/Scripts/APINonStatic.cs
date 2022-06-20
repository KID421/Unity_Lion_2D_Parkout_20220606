using UnityEngine;

namespace KID
{
    /// <summary>
    /// �D�R�A API
    /// �P�R�A���t�O�b��ݭn�@�ӡu���骫��v
    /// �u���骫��v�@�Ӧs�b������W���C������ Game Object
    /// </summary>
    public class APINonStatic : MonoBehaviour
    {
        // 1. �w�q���A������������O
        // 2. Unity �ݩʭ��O�����T�w����줣�O�ŭ� None
        // 3. �ϥΫD�R�A API
        [SerializeField]
        private GameObject turtle;
        [SerializeField]
        private Transform startPoint;

        private void Start()
        {
            // 1. ���o �D�R�A�ݩ�
            // �y�k�G���W��.�D�R�A�ݩ�
            print("�Ԫ��t���Ұʪ��A�G" + turtle.activeInHierarchy);
            print("�Ԫ��t�w�]�ϼh�G" + turtle.layer);
            print("�_�I���y�СG" + startPoint.position);

            // 2. �]�w �D�R�A�ݩ�
            // �y�k�G���W��.�D�R�A�ݩ� ���w �ȡF
            // turtle.activeInHierarchy = false; (���~�A��Ū�ݩ� �x��S�g)
            turtle.tag = "Player";
            turtle.layer = 4;
            startPoint.position = new Vector3(0, 5, 0);

            // 3. �ϥ� �D�R�A��k
            // �y�k�G���W��.�D�R�A��k(�������޼�)�F
            turtle.SetActive(false);
        }

        private void Update()
        {
            startPoint.Translate(0.5f, 0, 0);
            startPoint.Rotate(0, 0, 3.5f);
        }
    }
}
