using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerControl : MonoBehaviour {

	public Vector2 jumpForce = new Vector2(0,100);	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKey(KeyCode.W)){
			//GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
			GetComponent<Rigidbody2D> ().AddForce(jumpForce);
		}
		Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		if(screenPosition.y > Screen.height || screenPosition.y < 0 ){
			Die1();
		}
		if(Input.GetKey(KeyCode.A))
		transform.position += new Vector3(-7,0,0) * Time.deltaTime;

		if(Input.GetKey(KeyCode.D))
		transform.position += new Vector3(7,0,0) * Time.deltaTime;

		
	}
	void Die1() {
		Debug.Log("Game Over");
		SceneManager.LoadScene("Kalah");
	}
	void Die() {
		Debug.Log("Lanjut Level");
		SceneManager.LoadScene("Level2");
	}
	void Die3() {
		Debug.Log("Lanjut Level");
		SceneManager.LoadScene("Level3");
	}
	void Die4() {
		Debug.Log("Lanjut Level");
		SceneManager.LoadScene("finish");
	}
	void Die2() {
		Debug.Log("Nambah Sekor 100");
		//SceneManager.LoadScene("Level2");
	}

	void OnCollisionEnter2D(Collision2D coll){
		if(coll.gameObject.tag == "enemyTag"){
             Die1();
			 //Debug.Log("Sudah nabrak");
             
         }
		 if(coll.gameObject.tag == "pintuLevel"){
             Die();
			 //Debug.Log("Sudah nabrak");
             
         }
		 if(coll.gameObject.tag == "pintuLevel3"){
             Die3();
			 //Debug.Log("Sudah nabrak");
             
         }
		  if(coll.gameObject.tag == "pintulevelfinih"){
             Die4();
			 //Debug.Log("Sudah nabrak");
             
         }
		 if(coll.gameObject.tag == "hijaiyah"){
             Die2();
			 //Debug.Log("Sudah nabrak");
             
         }
		//Die();
	}
	
	
}
