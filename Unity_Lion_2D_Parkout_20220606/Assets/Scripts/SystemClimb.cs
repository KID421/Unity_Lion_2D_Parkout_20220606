using UnityEngine;

namespace KID
{
    public class SystemClimb : MonoBehaviour
    {
        [SerializeField, Header("���ʳt��"), Range(0, 100)]
        private float speed = 10;

        private Animator ani;
        private Rigidbody2D rig;
        private float horizontal;

        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            InputData();
            Move();
        }

        private void InputData()
        {
            horizontal = Input.GetAxis("Horizontal");
        }

        private void Move()
        {
            rig.velocity = new Vector2(horizontal * speed, rig.velocity.y);
        }
    }
}

