using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private FixedJoystick jys;
    [SerializeField] private Animator animator;

    [SerializeField] private float moveSpeed;
    private void FixedUpdate()
    {
        rb.velocity = new Vector3(jys.Horizontal * moveSpeed, rb.velocity.y, jys.Vertical * moveSpeed);//character movement (right-left) with jys
        if (jys.Horizontal != 0 || jys.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(rb.velocity * Time.deltaTime);//joystick'in yonune dogru karakteri dondurmek
            animator.SetBool("isWalking", true);

        }
        else
            animator.SetBool("isWalking", false);
        

    }
}
