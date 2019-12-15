using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObs : MonoBehaviour {

	public GameObject rocks;
	public int score = 0;
	GUIStyle guiStyle = new GUIStyle();
	// Use this for initialization
	void Start () {
		InvokeRepeating("CreateObstacle", 1f, 1.5f);
	}
	
	void CreateObstacle(){
		Instantiate(rocks);
		score++;
	}
	void OnGUI(){
		GUI.color = Color.black;
		guiStyle.fontSize = 40;
		GUI.Label(new Rect(0,0,300,50), "Score"+score.ToString(), guiStyle);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
