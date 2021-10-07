using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

public class RotatorAround : MonoBehaviour
{
   private Vector3 _rotatorPosition;
   [SerializeField] private Transform rotatePoint;
   [SerializeField] private float angle;

   private void Start()
   {
      _rotatorPosition = rotatePoint.position;
   }


   private void OnTriggerEnter(Collider other)
   {
      Debug.Log(other.gameObject.name);
      PlayerController playerController = other.gameObject.GetComponent<PlayerController>();
      playerController.Rotate(angle,_rotatorPosition);
   }
}



