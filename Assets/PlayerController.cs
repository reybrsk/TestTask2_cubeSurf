using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    private bool isMove = true;
    private bool isRotate = false;
    private float targetTimeRotate = 0f;
    private float timeToRotate;
    private float targetAngle;
    private Vector3 targetRotatePos;
    
    

    void FixedUpdate()
    {
        if (isMove)
        {
            Move();
        }

        if (isRotate)
        {
            Rotate(targetAngle,targetRotatePos);
        }

        
        
        
        
    }

    private void Move()
    {
        isRotate = false;
        isMove = true;
        transform.DOMove(transform.position + transform.forward * Time.fixedDeltaTime * speed,
            Time.fixedDeltaTime);    
    }


    public void Rotate(float angle,Vector3 rotatePos)
    {
        isMove = false;
        isRotate = true;
        targetAngle = angle;
        targetRotatePos = rotatePos;
        
        
        var radius = Vector3.Distance(this.transform.position, rotatePos);
        var segmentLenght = (float)((2 * Math.PI * radius) / 360) * angle;
       
        Debug.DrawLine(transform.position,transform.position+Vector3.up,Color.green,100f);
        timeToRotate = segmentLenght / speed;
        targetTimeRotate += Time.fixedDeltaTime;
        
        
        
        transform.RotateAround(rotatePos,Vector3.up, angle/segmentLenght/speed);
        Debug.Log("anglerotate"+angle / segmentLenght / speed);
        
        
        
        if (targetTimeRotate >= timeToRotate)
        {
            targetTimeRotate = 0f;
            Move();
        }
    }
    

   
}
