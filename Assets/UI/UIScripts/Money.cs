using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
   private Text moneytext;
   public int money = 0;

   private void Start()
   {
      moneytext = GetComponent<Text>();
   }

   public void MoneyPlus(int moneyPlus)
   {
      money += moneyPlus;
      Debug.Log(money);
      moneytext.text = money.ToString();
   }
}
