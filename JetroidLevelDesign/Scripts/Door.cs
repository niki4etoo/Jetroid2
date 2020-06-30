using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    Animator animator;
    new BoxCollider2D collider2D;
    public float closeDelay = .5f;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        collider2D = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnableCollider2D()
    {
        collider2D.enabled = true;
    }

    public void DisableCollider2D()
    {
        collider2D.enabled = false;
    }

    public void Open()
    {
        animator.SetInteger("AnimState", 1);
    }

    public void Close()
    {
        StartCoroutine(CloseNow());
    }

    IEnumerator CloseNow()
    {
        yield return new WaitForSeconds(closeDelay);
        animator.SetInteger("AnimState", 2);
    }

}
