using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAlienAttributes : MonoBehaviour {
    public float alienAnimationSpeed;

    private Animator alienAnimator;

    private void Start()
    {
        AlienSpeed(alienAnimationSpeed);
    }

    public void AlienSpeed(float speed)
    {
        alienAnimator = GetComponent<Animator>();
        alienAnimator.SetFloat("Alien_Animate_Speed", speed);
    }
}
