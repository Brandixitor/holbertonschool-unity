using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    Animator animator;

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
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isRunning = animator.GetBool("isRunning");
        float Horizontalmoves = playerControls.Player.move.ReadValue<Vector2>().x;
        float Verticalmoves = playerControls.Player.move.ReadValue<Vector2>().y;

        if (!isRunning && (Horizontalmoves != 0 || Verticalmoves != 0))
            animator.SetBool("isRunning", true);
        else if (isRunning && (Horizontalmoves == 0 && Verticalmoves == 0))
            animator.SetBool("isRunning", false);
    }
}
