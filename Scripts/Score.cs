using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public int score;
	public bool gameOver;
	public Text scoreText;
	// Use this for initialization
	void Start () {
		score = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(!gameOver){
			SetCountText();
		}else{
			winner();
		}
	}
	
	private void OnTriggerEnter(Collider other)
    {
		if(other.gameObject.tag.Equals("Pawn")){
			score++;
		}
		if(other.gameObject.tag.Equals("Knight")){
			score += 3;
		}
		if(other.gameObject.tag.Equals("Bishop")){
			score += 3;
		}
		if(other.gameObject.tag.Equals("Rook")){
			score += 5;
		}
		if(other.gameObject.tag.Equals("Queen")){
			score += 9;
		}
		if(other.gameObject.tag.Equals("King")){
			score = 0;
			gameOver = true;
		}
		// Debug.Log("entered");
    }
	
	private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag.Equals("Pawn")){
			score--;
		}
		if(other.gameObject.tag.Equals("Knight")){
			score -= 3;
		}
		if(other.gameObject.tag.Equals("Bishop")){
			score -= 3;
		}
		if(other.gameObject.tag.Equals("Rook")){
			score -= 5;
		}
		if(other.gameObject.tag.Equals("Queen")){
			score -= 9;
		}
		if(other.gameObject.tag.Equals("King")){
			score = 0;
			gameOver = true;
		}
    }
	
	void SetCountText ()
    {
        scoreText.text = "Score: " + score.ToString ();
    }
	
	void winner(){
		scoreText.text = "You win!";
	}
	
}
