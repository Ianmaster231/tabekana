﻿
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class ChangeTextLevel: MonoBehaviour {
	
	private Text txtRef;



	// Use this for initialization
	void Start () {
		txtRef = GetComponent<Text>();//or provide from somewhere else (e.g. if you want via find GameObject.Find("CountText").GetComponent<Text>();)
		String value = null;
		value = GlobalVariables.actLearnLvl;
		
		Char delimiter = ' ';
		String[] substrings = value.Split(delimiter);
		string a = substrings [0];
		string b = substrings [1];
		char u = char.Parse (a);

		if (u.Equals ('h')) {
			txtRef.text = "Lesson " + b.ToString ()+ " (あ)";
		}
		if (u.Equals ('k')) {
			txtRef.text = "Lesson " + b.ToString ()+ " (ア)";

		}

	}

	// Update is called once per frame
	void Update () {

	}
}
