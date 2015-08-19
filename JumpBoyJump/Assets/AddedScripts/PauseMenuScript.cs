using UnityEngine;
using System.Collections;

public class PauseMenuScript : MonoBehaviour {

	//refrence for the pause menu panel in the hierarchy
	public GameObject PauseMenuPanel;

	public GameObject _pauseButton;
	public GameObject _brakeButton;
	public GameObject _goButton;
	public GameObject _eatSnack;
	public GameObject _upButton;

	//animator reference
	private Animator anim;

	// Use this for initialization
	void Start () {
		//unpause the game on start
		Time.timeScale = 1;
		//get the animator component
		anim = PauseMenuPanel.GetComponent<Animator>();
		//disable it on start to stop it from playing the default animation
		anim.enabled = false;
	}
	
	// Update is called once per frame
	public void Update () 
	{

	}
	
	//function to pause the game
	public void PauseGame(string playThis){
		//enable the animator component
		anim.enabled = true;
		//play the Slidein animation
		anim.Play(playThis);
		ShowUI(false);
		//freeze the timescale
		Time.timeScale = 0;
	}
	//function to unpause the game
	public void UnpauseGame(string playThis){
		//play the SlideOut animation
		anim.Play(playThis);
		//set back the time scale to normal time scale
		Time.timeScale = 1;
		ShowUI(true);
	}

	public void ShowUI(bool activate)
	{
		_pauseButton.SetActive (activate);
		_brakeButton.SetActive (activate);
		_goButton.SetActive (activate);
		_eatSnack.SetActive (activate);
		_upButton.SetActive (activate);
	}
}
