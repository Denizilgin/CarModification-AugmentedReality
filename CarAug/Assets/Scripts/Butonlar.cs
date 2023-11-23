using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Butonlar : MonoBehaviour
{
   public Button myButton;

   void Start()
   {
    myButton = gameObject.GetComponent<Button>();
      
   }

   void Update(){myButton.onClick.AddListener(ButtonClick);}

   public static string buttonName;
   void ButtonClick()
    {       
      buttonName = myButton.name;
    }
}
