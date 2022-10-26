using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slidiing : MonoBehaviour
{
    private Animator animator;
    private BoxCollider2D boxCollider2D;

    [SerializeField]
    private float offsetY = -0.14f;
    [SerializeField]
    private float sizeY = 0.1f;

    private bool isSliding = false;

    private Vector2 startOffset;
    private Vector2 startSize;

    void Start()
    {
        animator = GetComponent<Animator>();
        boxCollider2D = GetComponent<BoxCollider2D>();
        startOffset = boxCollider2D.offset;
        startSize = boxCollider2D.size;
    }

    void Update()
    {
        bool canSlide = !animator.GetBool("IsFly");
        if (canSlide == false) return;
        if (isSliding)
        {
            EndSlide();
        }
        else
        {
            StartSlide();
        }
    }
    private void StartSlide()
    {
        bool isKeyDown = Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.DownArrow);
        if (isKeyDown)
        {
            boxCollider2D.offset = new Vector2(startOffset.x, offsetY);
            boxCollider2D.size = new Vector2(startSize.x, sizeY);
            isSliding = true;
            animator.SetBool("IsDodge", isSliding);
        }
    }
    private void EndSlide()
    {
        bool isKeyUp = Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.DownArrow);
        if (isKeyUp)
        {
            boxCollider2D.offset = startOffset; 
            boxCollider2D.size = startSize;

            isSliding = false;
            animator.SetBool("IsDodge", isSliding);
        }
    }
}