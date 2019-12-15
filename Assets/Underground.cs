using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Underground : MonoBehaviour
{
    // Start is called before the first frame update
		private LevelManager gameLevelManager;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){
	  	if(other.tag == "Player"){
    		GameOver();
    		Debug.Log("tes");
	  	}
	  }

	  public void GameOver(){
	  	SceneManager.LoadScene("GameOver");
	  }
}
