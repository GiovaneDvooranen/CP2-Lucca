using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator animator;

    public void PlayHipHop()
    {
        animator.SetTrigger("HipHop");
    }

    public void PlayThriller()
    {
        animator.SetTrigger("Thriller");
    }

    public void RotateCharacter()
    {
        animator.transform.Rotate(0, 90, 0);
    }
}