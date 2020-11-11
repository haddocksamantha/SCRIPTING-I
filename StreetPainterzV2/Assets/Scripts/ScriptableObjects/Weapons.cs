using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;

public class Weapons : MonoBehaviour
{
  public int weapon = 0;

  private string noWeapon;

  void Start()
  {
    noWeapon = "No Weapon Selected";
    WeaponAssignments();
  }

  void Update()
  {
    if (Input.GetKeyDown("W"))
    {
      weapon++;
      WeaponsSwitch();
    }
  }
  
  void WeaponsSwitch()
  {
    switch (weapon)
    {
      case 10:
        weapon = 0;
        break;
      case 9:
        Instantiate(bowlingBallPrefab);
        break;
      case 8:
        Instantiate(wandPrefab);
        break;
      case 7:
        Instantiate(bombPrefab);
        break;
      case 6:
        Instantiate(featherPrefab);
        break;
      case 5:
        Instantiate(katanaPrefab);
        break;
      case 4:
        Instantiate(knifePrefab);
        break;
      case 3:
        Instantiate(gunPrefab);
        break;
      case 2:
        Instantiate(swordPrefab);
        break;
      case 1:
        Instantiate(nunchakuPrefab);
        break;
      default:
        Debug.Log(noWeapon);
        break;
    }
  }

  public GameObject bombPrefab;
  public GameObject katanaPrefab;
  public GameObject knifePrefab;
  public GameObject gunPrefab;
  public GameObject swordPrefab;
  public GameObject featherPrefab;
  public GameObject nunchakuPrefab;
  public GameObject wandPrefab;
  public GameObject bowlingBallPrefab;

  void WeaponAssignments()
  {
    bombPrefab = GetComponent<GameObject>();
    katanaPrefab = GetComponent<GameObject>();
    knifePrefab = GetComponent<GameObject>();
    gunPrefab = GetComponent<GameObject>();
    swordPrefab = GetComponent<GameObject>();
    featherPrefab = GetComponent<GameObject>();
    nunchakuPrefab = GetComponent<GameObject>();
    wandPrefab = GetComponent<GameObject>();
    bowlingBallPrefab = GetComponent<GameObject>();
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