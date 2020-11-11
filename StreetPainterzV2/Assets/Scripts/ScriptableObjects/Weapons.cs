using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu]
public class Weapons : ScriptableObject
{
  public int weapon = 5;

  private string noWeapon;

  void Start()
  {
    noWeapon = "No Weapon Selected";
  }
  
  void WeaponsSwitch()
  {
    switch (weapon)
    {
      case 5:
        GameObject.FindWithTag("Sword");
        break;
      case 4:
        GameObject.FindWithTag("Gun");
        break;
      case 3:
        GameObject.FindWithTag("Knife");
        break;
      case 2:
        GameObject.FindWithTag("Katana");
        break;
      case 1:
        GameObject.FindWithTag("Bomb");
        break;
      default:
        Debug.Log(noWeapon);
        break;
    }
  }
 
  
  
  
  
  
  
  
}






/*
 public GameObject Shield;
  public GameObject Potions;
  public GameObject ExtraHealth;
  public GameObject Buffs;
  public GameObject SuperShield;
  public enum Defenses()
  {
    Shield,
    Potions,
    ExtraHealth,
    Buffs,
    SuperShield
  }

  void Start()
  {
    Shield = GetComponent<GameObject>();
    Potions = GetComponent<GameObject>();
    ExtraHealth = GetComponent<GameObject>();
    Buffs = GetComponent<GameObject>();
    SuperShield = GetComponent<GameObject>();

  }

  public Defenses currentDefence;

  public void RunCurrentDefense()
  {
    switch (currentDefence)
    {
      case Defenses.Shield;
        break;
      case Defenses.Potions ;
        break;
      case Defenses.ExtraHealth ;
        break;
      case Defenses.Buffs ;
        break;
      case Defenses.SuperShield ;
        break;
    }
  }
  */