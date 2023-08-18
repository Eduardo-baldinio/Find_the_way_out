using UnityEngine;

public class InputSystem : MonoBehaviour
{
    private Player player;
    private AnimationPlayer playerAnimation;
   
    void Start()
    {
        player = GetComponent<Player>();
        playerAnimation = GetComponent<AnimationPlayer>();
    }

    private void FixedUpdate()
    {
        InputMove();
    }

    private void Update()
    {
        InputJump();
    }

    private void InputMove()
    {
        player.inputHorizontal = Input.GetAxis("Horizontal");
    }

    private void InputJump() 
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.isJump = true;
            return;
        }

        player.isJump = false;
    }
}

