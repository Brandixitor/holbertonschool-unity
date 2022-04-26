using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector3 cameraOffset;

    public Transform player;

    public float sensitivity = 0.5f;

    public bool isInverted;

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
        cameraOffset = transform.position - player.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isInverted)
        {
            var MouseY = playerControls.Player.LookY.ReadValue<float>() * Time.deltaTime * 40.0f;
            transform.Rotate(-MouseY, 0, 0);
        }

        cameraOffset = Quaternion.AngleAxis(playerControls.Player.LookX.ReadValue<float>() * sensitivity, Vector3.up) * cameraOffset;
        transform.position = player.position + cameraOffset;

        transform.LookAt(player.position);

    }


}
