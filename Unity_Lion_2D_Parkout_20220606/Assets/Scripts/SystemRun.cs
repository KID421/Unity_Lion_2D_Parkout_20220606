using UnityEngine;  // �ޥ� Unity ���� �R�W�Ŷ� (API)

namespace KID
{
    // C# �q�Ź��ܦ����骫��
    // 1. �����W���C������ Game Object �Ǧ�u�����
    // 2. �N���}�����b�Ӫ����ܦ�����

    /// <summary>
    /// �]�B�t��
    /// </summary>
    public class SystemRun : MonoBehaviour
    {
        #region ��ơG�O�s�t�λݭn�����

        // ��� Field�G�O�s���
        // �y�k�G
        // �׹��� ��������� ���ۭq�W�� (���w �w�]��)�F

        // �׹���
        // ���}�G��ܦb���O�A���\��L���O�s�� public
        // �p�H�G����ܦb���O�A�����\��L���O�s�� private (�ʸ�)

        // [] Attritube �ݩʡA�B�~�\��
        // Serialize Field �ǦC�����G�N�p�H������
        // Heder ���D�G�i�H�ϥΤ���
        // Tooltip ���ܡG�i�H�ϥΤ���
        // Range �d��G�ȭ���ƭ�������� int, float ,byte, long
        [SerializeField, Header("�]�B�t��"), Tooltip("�o�O���⪺�]�B�t��"), Range(0, 100)]
        private float speedRun = 3.5f;
        [SerializeField, Header("���D����"), Range(0, 3000)]
        private float heightJump = 350;
        private Animator ani;
        private Rigidbody2D rig;
        #endregion

        #region �\��G��@�Өt�Ϊ�������k

        #endregion

        #region �ƥ�G�{���J�f
        // �}�l�ƥ�G����C���ɰ���@��
        // ��l�Ƴ]�w�A�Ҧp�G�^���p�� 500 ���B�ͩR��l�� 3 ��..
        private void Start()
        {
            print("���o�A�U�w :D");
        }
        #endregion
    }
}
