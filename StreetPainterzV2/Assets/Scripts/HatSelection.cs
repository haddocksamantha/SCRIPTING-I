using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class HatSelection : MonoBehaviour
{
  public GameObject topHatPrefab;
  public GameObject chefHatPrefab;
  public GameObject graduationHatPrefab;
  public GameObject cowboyHatPrefab;
  public GameObject witchHatPrefab;

  public GameObject hatMenuCanvas;

  void Start()
  {
    hatMenuCanvas = GetComponent<GameObject>();
    HatPrefabs();
  }

  void HatPrefabs()
  {
    topHatPrefab = GetComponent<GameObject>();
    chefHatPrefab = GetComponent<GameObject>();
    graduationHatPrefab = GetComponent<GameObject>();
    cowboyHatPrefab = GetComponent<GameObject>();
    witchHatPrefab = GetComponent<GameObject>();
  }

  public void HatMenuButton()
  {
    hatMenuCanvas.SetActive(true);
  }
  
  public void TopHat()
  {
    Instantiate(topHatPrefab);
    hatMenuCanvas.SetActive(false);
  }

  public void ChefHat()
  {
    Instantiate(chefHatPrefab);
    hatMenuCanvas.SetActive(false);
  }

  public void GraduationHat()
  {
    Instantiate(graduationHatPrefab);
    hatMenuCanvas.SetActive(false);
  }

  public void CowboyHat()
  {
    Instantiate(cowboyHatPrefab);
    hatMenuCanvas.SetActive(false);
  }

  public void WitchHat()
  {
    Instantiate(witchHatPrefab);
    hatMenuCanvas.SetActive(false);
  }
  
}
