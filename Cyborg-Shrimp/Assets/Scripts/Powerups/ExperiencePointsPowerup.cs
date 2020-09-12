using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperiencePointsPowerup : MonoBehaviour
{
    public int XP;
    private void OnTriggerEnter(Collider other)
    {
        XP++;
        print(XP);
    }
}
