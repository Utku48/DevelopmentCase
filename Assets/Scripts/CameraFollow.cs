using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Vector3 offset;//camera given distance from the player
    [SerializeField] Transform target;
    [SerializeField] private float smoothTime; //control how smoothg the camera
    private Vector3 currentVelocity = Vector3.zero;




    private void Awake()
    {
        //CameraPos-PlayerPos = offset (distance)
        offset = transform.position - target.position;// where will define our offset value  

    }
    private void LateUpdate()
    {
        Vector3 TargetPos = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, TargetPos, ref currentVelocity, smoothTime);
    }
}