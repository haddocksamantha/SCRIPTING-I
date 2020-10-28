using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class CharacterData : ScriptableObject
{
    public int score;
    public int playerAge;
    public float health;
    public string playerName;
    public bool canPlay;
    public GameObject playerHairColor;
    public GameObject playerEyeColor;
    public GameObject playerArt;
    public Transform playerTransform;
    
}
