using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnPlay(){
	SceneManager.LoadScene("GameLevel");
}
    public void OnMenu(){
	SceneManager.LoadScene("Menu");
}
	public void OnHelp(){
	SceneManager.LoadScene("Help");
}
	public void OnCredits(){
	SceneManager.LoadScene("Credits");
}
    public void OnLevel1(){
	SceneManager.LoadScene("Level1");
}
    public void OnLevel2(){
	SceneManager.LoadScene("Level2");
}
	public void OnLevel3(){
	SceneManager.LoadScene("Level3");
}
public void OnGameOver(){
	SceneManager.LoadScene("GameOver");
}
// public void Jump(){
// 	AddForce (new Vector2(0, Parameters.JumpMagnitude));

// }
	
}

