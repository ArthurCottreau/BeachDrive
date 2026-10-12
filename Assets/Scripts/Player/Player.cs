using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float turn_speed;
    public float gravityForce = 9.81f;

    private CharacterController controller;
    private Vector2 player_input;
    private Vector3 velocity;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        player_input.x = Input.GetAxisRaw("Horizontal");
        player_input.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        float rot_velocity = player_input.x * player_input.y * turn_speed;
        velocity = transform.forward * player_input.y * speed;

        handleGravity();

        transform.Rotate(Vector3.up, rot_velocity * Time.deltaTime);
        controller.Move(velocity * Time.deltaTime);
    }


    private void handleGravity()
    {
        if (controller.isGrounded)
        {
            velocity.y = 0.0f;
        }
        else
        {
            velocity.y -= gravityForce;
        }
    }
}
