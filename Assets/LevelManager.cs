using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float respawnDelay;
    public Player gamePlayer;
    public int coins;
    public Text coinText;
    void Start()
    {
         gamePlayer = FindObjectOfType<Player> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseUp()
     {
         SceneManager.LoadScene("Level1");
     }


    public void AddCoins(int numberOfCoins){
      coins += numberOfCoins;
      coinText.text = "Score : " + coins;
    }
}
