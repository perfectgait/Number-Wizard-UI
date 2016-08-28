using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	int min;
	int max;
	int guess;
	public int guessesRemaining = 10;
	public Text currentGuess;

	// Use this for initialization
	void Start() {
		StartGame();
	}
	
	void StartGame() {
		min = 1;
		max = 1000;
		
		NextGuess();
//		guess = 500;
//		guess = Random.Range(min, max + 1);
		// Fix rounding issues in NextGuess
//		max++;
		
//		currentGuess.text = guess.ToString();
	}
	
	public void GuessHigher() {
		min = guess;
		NextGuess();
	}
	
	public void GuessLower() {
		max = guess;
		NextGuess();
	}
	
	void NextGuess() {
//		guess = (max + min) / 2;
		guess = Random.Range(min, max + 1);
		guessesRemaining--;
		currentGuess.text = guess.ToString();
		
		if (guessesRemaining <= 0) {
			Application.LoadLevel("Win");
		}
	}
}
