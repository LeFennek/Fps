﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour 
{

public void LoadScene(string sceneName)
{
   SceneManager.LoadScene (sceneName);
}

   public void Quit ()
   {
   	   Debug.Log("Quit");
	   Application.Quit();
   }
}