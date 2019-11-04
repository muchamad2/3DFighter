using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace FighterAcademy
{
    public class PlayerMove : MonoBehaviour
    {
        //controller yang digunakan untuk menggerakkan karakter
        CharacterController charController;

        //controller yang digunakan untuk memainkan animasi dari karakter
        [SerializeField]
        CharacterAnimation playerAnimation;

        //variabel yang digunakan untuk memperoleh kecepatan gerak, tingkat gravitasi
        //kecepatan putaran
        [SerializeField]
        
        public float movement_speed = 3f;
        public float gravity = 9.8f;
        public float rotation_speed = 0.15f;
        public float rotateDegressPerSecond = 180f;
        //variabel yang digunakan untuk memperoleh arah gerak karakter
        public Vector3 moveDirection;
        public Vector3 rotation_direction;
        // Start is called before the first frame update
        void Awake()
        {
            charController = GetComponent<CharacterController>();
            playerAnimation = GetComponent<CharacterAnimation>();
            
        }

        private void Start()
        {
            
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            Move();
            AnimatateWalk();
        }
        void Move()
        {
            //fungsi untuk memperoleh inputan dan menggerakkan karakter ketika
            //player menekan inputan.
            if (Input.GetAxis(ControllerTags.MOVE_TAG) < 0)
            {
                moveDirection = transform.forward;
                moveDirection.y -= gravity * Time.deltaTime;

                charController.Move(moveDirection * movement_speed * Time.deltaTime);
            }
            else if (Input.GetAxis(ControllerTags.MOVE_TAG) > 0)
            {
                moveDirection = -transform.forward;
                moveDirection.y -= gravity * Time.deltaTime;

                charController.Move(moveDirection * movement_speed * Time.deltaTime);

            }
            //fungsi yang membuat karakter berhenti ketika player tidak menekan inputan
            else
            {
                charController.Move(Vector3.zero);
            }
            //rotate();
        }
        void rotate()
        {
            rotation_direction = Vector3.zero;

            if (Input.GetAxis("Horizontal") < 0)
            {
                rotation_direction = transform.TransformDirection(Vector3.left);
            }
            if (Input.GetAxis("Horizontal") > 0)
            {
                rotation_direction = transform.TransformDirection(Vector3.right);
            }

            if (rotation_direction != Vector3.zero)
            {
                transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(rotation_direction),
                    rotateDegressPerSecond * Time.deltaTime);
            }
        }
        //fungsi yang menjalankan animasi bersamaan dengan ketika player menekan inputan
        //pada fungsi ini animasi yang dijalankan adalah animasi gerak berjalan
        void AnimatateWalk()
        {
            if (charController.velocity.sqrMagnitude != 0)
            {
                playerAnimation.Walk(true);
            }
            else
            {
                playerAnimation.Walk(false);
            }
        } 

       
    }

}
