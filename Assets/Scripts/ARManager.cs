using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARManager : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed;

    private Vector3 snapPosition;
    private Vector3 initialScale;
    private Quaternion originalRotation;
    private Animator animator;
    private float initialDistance;

    // Start is called before the first frame update
    void Start()
    {
        snapPosition = this.transform.position;
        originalRotation = transform.rotation;

        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        // Rotate the object
        if (Input.touchCount == 1)
        {
            Touch touch0 = Input.GetTouch(0);

            if (touch0.phase == TouchPhase.Moved)
            {
                transform.Rotate(0f, touch0.deltaPosition.x, 0f);
            }
        }

        // Scale the object
        if (Input.touchCount == 2)
        {
            var touchZero = Input.GetTouch(0);
            var touchOne = Input.GetTouch(1);

            // If losing finger contact do nothing
            if (touchZero.phase == TouchPhase.Ended || touchZero.phase == TouchPhase.Canceled ||
                touchOne.phase == TouchPhase.Ended || touchOne.phase == TouchPhase.Canceled)
            {
                return; 
            }

            if (touchZero.phase == TouchPhase.Began || touchOne.phase == TouchPhase.Began)
            {
                initialDistance = Vector2.Distance(touchZero.position, touchOne.position);
                initialScale = transform.localScale;
            }
            else // If touch is moved
            {
                var currentDistance = Vector2.Distance(touchZero.position, touchOne.position);

                // if touched accidentally or pinch moved is small
                if (Mathf.Approximately(initialDistance, 0))
                {
                    return; // do nothing
                }

                var factor = currentDistance / initialDistance;
                transform.localScale = initialScale * factor;
            }
        }
    }

    public void DanceSamba()
    {
        animator.SetBool("DanceSamba", true);
    }

    public void Dead()
    {
        animator.SetBool("Dead", true);
    }

    public void Kick()
    {
        animator.SetBool("Kick", true);
    }

    public void Breakdance()
    {
        animator.SetBool("Shuffling", true);
    }

    public void BackToIdle()
    {
        PrepareModel();

        animator.SetBool("DanceSamba", false);
        animator.SetBool("Dead", false);
        animator.SetBool("Shuffling", false);
        animator.SetBool("Kick", false);
    }

    public void PrepareModel()
    {
        transform.position = snapPosition;
        transform.rotation = Quaternion.Slerp(transform.rotation, originalRotation, Time.time * rotationSpeed);
    }
}
