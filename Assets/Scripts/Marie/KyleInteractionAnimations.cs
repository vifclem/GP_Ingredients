using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum KyleAnim
{
    OpenDoor,
    PushButton,
    LockedDoor
}

public class KyleInteractionAnimations : MonoBehaviour
{
    private Animator _animator;

    public static bool AnimationInProgress = false;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void BeginAnimation()
    {
        AnimationInProgress = true;
    }

    public void EndAnimation()
    {
        AnimationInProgress = false;
    }

    public bool PlayAnimation(KyleAnim animation)
    {
        //if an animation is already in progress or we are trying to do something while walking
        if (AnimationInProgress || _animator.GetFloat("Speed") > 1) return false;
        switch (animation)
        {
            case KyleAnim.OpenDoor:
            {
                _animator.SetTrigger("Open Door");
                break;
            }
            case KyleAnim.PushButton:
            {
                _animator.SetTrigger("Push Button");
                break;
            }
            case KyleAnim.LockedDoor:
            {
                _animator.SetTrigger("Locked Door");
                break;
            }
        }

        return false;
    }
}
