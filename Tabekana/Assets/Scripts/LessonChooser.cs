﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class LessonChooser : MonoBehaviour{
	// string level;

	public void leerClic(string level){
		// Guardo en la variable global el nivel
		GlobalVariables.actLearnLvl = level;
		//GlobalVariables.actGameLvl = level;

		Char delimiter = ' ';
		String[] substrings = level.Split(delimiter);
		string a = substrings [0];
		string b = substrings [1];
		char u = char.Parse (a);
		int d = int.Parse (b);

		//if (u.Equals ('h')) {
			//Hiragana
			if (d > 0 && d<16) {
				AsyncOperation ao = SceneManager.LoadSceneAsync("LevelInfo1");
				//SceneManager.LoadScene("LevelInfo1", LoadSceneMode.Single);
			}else{
				AsyncOperation ao = SceneManager.LoadSceneAsync("LevelInfo");
				//SceneManager.LoadScene("LevelInfo", LoadSceneMode.Single);
			}
		//}
		gameObject.AddComponent <AudioSource>();
		GetComponent<AudioSource> ().clip = Resources.Load ("button_click") as AudioClip;
		GetComponent<AudioSource>().volume = 1;
		GetComponent<AudioSource>().Play();
	}
}
