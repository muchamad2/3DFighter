using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private CharacterController charController;
    public float movement_speed = 3f;


    private void Awake()
    {
        charController = GetComponent<CharacterController>();
    }
    private void Update()
    {
        Move();
    }
    void FixedUpdate()
    {

    }

    void Move()
    {
        if (Input.GetAxis(Axis.HORIZONTAL_AXIS) > 0)
        {
            Vector3 moveDirection = transform.forward;
            charController.Move(moveDirection * movement_speed * Time.fixedDeltaTime);
        }
    }
}
