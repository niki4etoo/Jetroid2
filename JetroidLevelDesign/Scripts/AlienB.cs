using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienB : MonoBehaviour
{
    private Animator animator;
    private bool readyToAttack;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D target)
    {
        if(target.gameObject.CompareTag("Player"))
        {
            if(readyToAttack)
            {
                var explode = target.GetComponent<Explode>();
                explode.OnExplode();
            }
            else
            {
                animator.SetInteger("AnimState", 1);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D target)
    {
        readyToAttack = false;
        animator.SetInteger("AnimState", 0);
    }

    void Attack()
    {
        readyToAttack = true;
    }
}
