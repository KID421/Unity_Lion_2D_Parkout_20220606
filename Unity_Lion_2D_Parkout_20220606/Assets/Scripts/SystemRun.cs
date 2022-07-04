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
        
        private Animator ani;
        private Rigidbody2D rig;
        #endregion

        #region �\��G��@�Өt�Ϊ�������k
        // ��k Method 
        // �y�k
        // �׹��� �Ǧ^������� ��k�W��(�Ѽ�) { �{�� }
        /// <summary>
        /// �]�B�\��
        /// </summary>
        private void Run()
        {
            // print("�]�B��~");
            rig.velocity = new Vector2(speedRun, rig.velocity.y);
        }
        #endregion

        #region �ƥ�G�{���J�f
        // ����ƥ�G�}�l�ƥ�e����@���A���o���󵥵�
        private void Awake()
        {
            // ani ���w �Ԫ��t���W�� Animator
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

        // �}�l�ƥ�G����C���ɰ���@��
        // ��l�Ƴ]�w�A�Ҧp�G�^���p�� 500 ���B�ͩR��l�� 3 ��..
        private void Start()
        {
            // print("���o�A�U�w :D");
        }

        // ��s�ƥ�G�C���������Q�� 60FPS Frame per second
        private void Update()
        {
            // print("<color=yellow>��s�ƥ���椤~</color>");

            // �I�s��k�G��k�W��(�������޼�)�F
            Run();
        }

        // ������Q�Ŀ�ɰ���@��
        private void OnEnable()
        {
            
        }

        // ������Q�����ɰ���@��
        private void OnDisable()
        {
            // �[�t���k�s
            rig.velocity = Vector3.zero;
        }
        #endregion
    }
}
