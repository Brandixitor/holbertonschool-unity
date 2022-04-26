using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private float gravity = 9f;
    [SerializeField]
    private float jumpSpeed = 3.5f;
    [SerializeField]
    private float doubleJumpMultiplier = 0.5f;


    private CharacterController controller;

    private float directionY;

    private bool canDoubleJump = false;


    private PlayerControls playerControls;

    private void Awake()
    {
        playerControls = new PlayerControls();   
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = playerControls.Player.move.ReadValue<Vector2>().x;
        float verticalInput = playerControls.Player.move.ReadValue<Vector2>().y;

        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);

        if (controller.isGrounded)
        {
            canDoubleJump = true;
            if (playerControls.Player.jump.ReadValue<float>() == 1)
            {
                directionY = jumpSpeed;
            }
        } else
        {
            if ((playerControls.Player.jump.ReadValue<float>() == 1) && canDoubleJump)
            {
                directionY = jumpSpeed * doubleJumpMultiplier;
                canDoubleJump = false;
            }
        }

        directionY -= gravity * Time.deltaTime;

        direction.y = directionY;

        controller.Move(direction * speed * Time.deltaTime);

        if(transform.position.y < -50)
        {
            transform.position = new Vector3(0f, 40f, 0f);
        }
        
    }
}
