using UnityEngine;

namespace KID
{
    /// <summary>
    /// �޲z�L��
    /// </summary>
    public class ManagerPass : MonoBehaviour
    {
        [SerializeField, Header("�ؼЦW��")]
        private string nameTarget = "�Ԫ��t";
        [SerializeField, Header("�]�B�t��")]
        private SystemRun systemRun;
        [SerializeField, Header("���D�t��")]
        private SystemJump systemJump;
        [SerializeField, Header("�����޲z��")]
        private ManagerFinal managerFinal;

        #region �䤤�@�Ӫ��󦳤Ŀ� Is Trigger
        // ��Ӫ���I���ɰ���@��
        private void OnTriggerEnter2D(Collider2D collision)
        {
            // print(collision.name);

            // �p�G �I�����󪺦W�� �]�t (�Ԫ��t)
            if (collision.name.Contains(nameTarget))
            {
                systemRun.enabled = false;      // �����]�B�t��
                systemJump.enabled = false;     // �������D�t��
                managerFinal.enabled = true;    // �Ұʵ����޲z��
                managerFinal.stringTitle = "���ߧA�L���F~";
            }
        }

        // ��Ӫ���I�����}�ɰ���@��
        private void OnTriggerExit2D(Collider2D collision)
        {
            
        }

        // ��Ӫ���I�����|�ɫ������
        private void OnTriggerStay2D(Collider2D collision)
        {
            
        }
        #endregion

        #region ��Ӫ��󳣨S���Ŀ� Is Trigger
        private void OnCollisionEnter2D(Collision2D collision)
        {
            
        }

        private void OnCollisionExit2D(Collision2D collision)
        {
            
        }

        private void OnCollisionStay2D(Collision2D collision)
        {
            
        }
        #endregion
    }
}

