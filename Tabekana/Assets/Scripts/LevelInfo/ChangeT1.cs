﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class ChangeT1: MonoBehaviour {

	private Text txtRef;



	// Use this for initialization
	void Start () {
		txtRef = GetComponent<Text>();//or provide from somewhere else (e.g. if you want via find GameObject.Find("CountText").GetComponent<Text>();)
		String value = null;
		value = GlobalVariables.actLearnLvl;


		Char delimiter = ' ';
		String[] substrings = value.Split(delimiter);
		string b = substrings [1];
		int d = int.Parse (b);

			if (d==16){
				//Lesson 1
				//m_tittletex="Lesson 1";
				txtRef.text = "kya";

			}
			if (d==17){
				//Lesson 2
				txtRef.text = "cha";
			}
			if (d==18) {
				//Lesson 3
				txtRef.text = "hya";
			}
			if (d==19) {
				//Lesson 4
				txtRef.text = "rya";
			}
			if (d==20) {
				//Lesson 5
				txtRef.text = "ja";
			}
			if (d==21) {
				//Lesson 6
				txtRef.text = "bya";
			}
			if (d==22) {
				//Lesson 7
				txtRef.text = "pya";
			}
				
		}

	// Update is called once per frame
	void Update () {

	}
}
