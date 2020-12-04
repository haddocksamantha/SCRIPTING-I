using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashingLightScript : MonoBehaviour
{
   public Animator lightFlashing;

   void Start()
   {
      lightFlashing = GetComponent<Animator>();
   }

   void Update()
   {
      LightKey();
   }

   void LightKey()
   {
      if (Input.GetKeyDown("L"))
      {
         lightFlashing.Play("FlashingLight");
      }
   }
   
}
