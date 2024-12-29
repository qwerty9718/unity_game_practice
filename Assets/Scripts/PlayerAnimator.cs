using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] private Player player;
    private Animator animator;
    private const string IsWalk = "isWalk";
    private void Awake()
    {
       animator = GetComponent<Animator>();
    }

    private void Update()
    {
        animator.SetBool(IsWalk, player.IsWalking());
    }
}
