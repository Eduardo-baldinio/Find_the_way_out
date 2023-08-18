using UnityEngine;

public class AnimationPlayer : MonoBehaviour
{
    private Animator _playerAnim;

    void Start()
    {
       _playerAnim = GetComponent<Animator>();
    }
    
    public void PlayAnimation(float input)
    {
        _playerAnim.applyRootMotion = false;

        if (input != 0)
        {
            _playerAnim.SetTrigger("Run");
        }
        else
        {
            _playerAnim.SetTrigger("Idle");
        }

        _playerAnim.applyRootMotion = true;
    }
}
