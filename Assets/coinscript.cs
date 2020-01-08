using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinscript : MonoBehaviour
{
  	public int coinValue;
    private LevelManager gameLevelManager;
    // Start is called before the first frame update
    void Start()
    {
        gameLevelManager = FindObjectOfType<LevelManager> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){
	    if(other.tag == "Player"){
      	AudioSource.PlayClipAtPoint
        (this.GetComponent<AudioSource>().clip, this.transform.position, 20f);
      	Destroy(this.gameObject);
        gameLevelManager.AddCoins(coinValue);
	    }
  	}
}
