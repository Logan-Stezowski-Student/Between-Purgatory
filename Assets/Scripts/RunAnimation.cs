using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Player))]
public class RunAnimation : MonoBehaviour
{
    Player player;
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        player = GetComponent<Player>();    
    }
    // Update is called once per frame
    void Update()
    {
        animator.SetBool("isRunning", player.isRunning);
    }
}
