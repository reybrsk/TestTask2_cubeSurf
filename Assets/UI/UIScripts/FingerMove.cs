using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class FingerMove : MonoBehaviour
{
    private bool isleft;
    public Transform leftPoint;
    public Transform rightPoint;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Move();
    }

    // Update is called once per frame
    void Update()
    {
        // if (!DOTween.IsTweening(gameObject))
        // {
        //     Move();
        // }
    }

    void Move()
    {
        if (isleft)
        {
            transform.DOMove(leftPoint.position, 1f).OnComplete(()=> Move());
            
        }
        else
        {
           
            transform.DOMove(rightPoint.position,1f).OnComplete(()=> Move());
            
        }
        isleft = !isleft;
    }
}
