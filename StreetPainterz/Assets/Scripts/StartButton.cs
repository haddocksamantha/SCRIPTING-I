﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
  public void SceneChanger(int SceneIndex)
  {
    SceneManager.LoadScene(SceneIndex);
  }
}
