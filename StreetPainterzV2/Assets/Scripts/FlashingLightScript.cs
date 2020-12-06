using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashingLightScript : MonoBehaviour
{
   public Animator lightFlashing;
   public KeyCode keyL = KeyCode.L;

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
      if (Input.GetKeyDown(keyL))
      {
         lightFlashing.Play("FlashingLight");
      }
   }
   
}
