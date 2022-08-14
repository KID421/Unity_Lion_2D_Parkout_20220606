using UnityEngine;

namespace KID
{
    /// <summary>
    /// ���D�t��
    /// </summary>
    public class SystemJump : MonoBehaviour
    {
        #region ���
        [SerializeField, Header("���D����"), Range(0, 3000)]
        private float heightJump = 350;
        [SerializeField, Header("�ˬd�a�O�ؤo")]
        private Vector3 v3CheckGroundSize = Vector3.one;
        [SerializeField, Header("�ˬd�a�O�첾")]
        private Vector3 v3CheckGroundOffset;
        [SerializeField, Header("�ˬd�a�O�C��")]
        private Color colorCheckGround = new Color(1, 0, 0.2f, 0.5f);
        [SerializeField, Header("�ˬd�a�O�ϼh")]
        private LayerMask layerCheckGround;
        [SerializeField, Header("���D�ʵe�Ѽ�")]
        private string nameJump = "�}�����D";
        [SerializeField, Header("���D����")]
        private AudioClip soundJump;

        private Animator ani;
        private Rigidbody2D rig;
        private bool clickJump;
        private bool isGround;
        private AudioSource aud;
        #endregion

        #region ���
        [SerializeField, Header("������"), Range(0, 3000)]
        private float heightJumpWall = 350;
        [SerializeField, Header("�ˬd����ؤo")]
        private Vector3 v3CheckWallSize = Vector3.one;
        [SerializeField, Header("�ˬd����첾")]
        private Vector3 v3CheckWallOffset;
        [SerializeField, Header("�ˬd����C��")]
        private Color colorCheckWall = new Color(0, 1, 0.2f, 0.5f);
        [SerializeField, Header("�ˬd����ϼh")]
        private LayerMask layerCheckWall;

        private SystemRun systemRun;
        private bool isWall;
        #endregion

        #region �ƥ�
        // ø�s�ϥ�
        // �b�s�边��ø�s���U�Ϊ��u���B�Ϊ��ιϤ��G�C�������|�X�{
        private void OnDrawGizmos()
        {
            // 1. �M�w�C��
            Gizmos.color = colorCheckGround;
            // 2. ø�s�ϥ�
            // transform.position ��e���󪺮y��
            Gizmos.DrawCube(transform.position + v3CheckGroundOffset, v3CheckGroundSize);

            /* ��� */
            Gizmos.color = colorCheckWall;
            Gizmos.DrawCube(transform.position + transform.TransformDirection(v3CheckWallOffset), v3CheckWallSize);
        }

        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
            aud = GetComponent<AudioSource>();
            systemRun = GetComponent<SystemRun>();
        }

        // Input API ��ĳ�b Update �I�s
        // �@��� 60 ��
        private void Update()
        {
            JumpKey();
            CheckGround();
            UpdateAnimator();

            CheckWall();
        }

        // �@��T�w 50 ��
        private void FixedUpdate()
        {
            JumpForce();
            JumpWallForce();
        }

        private void OnDisable()
        {
            ani.SetBool(nameJump, false);
        }
        #endregion

        #region �\��
        /// <summary>
        /// ���D����
        /// </summary>
        private void JumpKey()
        {
            // �p�G ���a ���U �ť��� �N���W ���D
            // if
            // switch
            // if �P�_���y�k�Gif (���L��) { ���L�� �� true ����{�� }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // print("���D~");
                clickJump = true;
            }
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                clickJump = false;
            }
        }

        /// <summary>
        /// ���D���O
        /// </summary>
        private void JumpForce()
        {
            // �p�G �I�����D �åB && �b�a�O�W
            if (clickJump && isGround)
            {
                rig.AddForce(new Vector2(0, heightJump));

                clickJump = false;
                // ���Ĩӷ�.����@������(���Ĥ��q�A���q)
                aud.PlayOneShot(soundJump, Random.Range(0.7f, 1.2f));
            }
        }

        /// <summary>
        /// ����O�D
        /// </summary>
        private void JumpWallForce()
        {
            if (clickJump && isWall)
            {
                clickJump = false;
                float y = transform.eulerAngles.y;
                transform.eulerAngles = new Vector3(0, y == 0 ? 180 : 0, 0);
                rig.AddForce(new Vector3(0, heightJump) + transform.right * heightJumpWall);
            }
        }

        /// <summary>
        /// �ˬd�O�_�I��a�O
        /// </summary>
        private void CheckGround()
        {
            // 2D �I���� = 2D ���z.�л\�����ϰ�(�����I�A�ؤo�A���סA�ϼh)�F
            Collider2D hit = Physics2D.OverlapBox(transform.position + v3CheckGroundOffset, v3CheckGroundSize, 0, layerCheckGround);
            // print("�I�쪺����G" + hit.name);

            isGround = hit;

            if (isGround) systemRun.enabled = true;
        }

        private void ResetSystemRun()
        {
            systemRun.enabled = true;
        }

        /// <summary>
        /// �ˬd�O�_�I�����
        /// </summary>
        private void CheckWall()
        {
            Collider2D hit = Physics2D.OverlapBox(transform.position + transform.TransformDirection(v3CheckWallOffset), v3CheckWallSize, 0, layerCheckWall);
            isWall = hit;
        }

        /// <summary>
        /// ��s�ʵe
        /// </summary>
        private void UpdateAnimator()
        {
            ani.SetBool(nameJump, !isGround);
        }
        #endregion
    }
}
