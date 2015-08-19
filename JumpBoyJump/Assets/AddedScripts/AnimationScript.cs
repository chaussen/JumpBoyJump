using UnityEngine;
using System.Collections;

public class AnimationScript : MonoBehaviour {

	public GameObject BreakfastPanel;
	public GameObject LunchPanel;
	public GameObject DinnerPanel;
	public GameObject SnackPanel;
	public GameObject Manager;
	private Animator _animBreakfast;
	private Animator _animLunch;
	private Animator _animDinner;
	private Animator _animSnack;
	private FoodStorage _storage;
	private AddFood _addFood;

	// Use this for initialization
	void Start () {
		//unpause the game on start
		Time.timeScale = 1;
		//get the animator component
		_animBreakfast = BreakfastPanel.GetComponent<Animator>();
		_animLunch = LunchPanel.GetComponent<Animator>();
		_animDinner = DinnerPanel.GetComponent<Animator>();
		_animSnack = SnackPanel.GetComponent<Animator>();
		//disable it on start to stop it from playing the default animation
		_animBreakfast.enabled = false;
		_animLunch.enabled = false;
		_animDinner.enabled = false;
		_animSnack.enabled = false;

		_storage = new FoodStorage ();
		_addFood = Manager.GetComponent<AddFood> ();
	}
	
	// Update is called once per frame
	public void Update () 
	{
		
	}
	
	//function to pause the game
	public void ChangePanel(int playThis){
		//enable the animator component
		_animBreakfast.enabled = true;
		_animLunch.enabled = true;
		_animDinner.enabled = true;
		_animSnack.enabled = true;

		switch (playThis)
		{
		case 1:
			_animBreakfast.Play("BreakFastOut");
			_animLunch.Play("LunchIn");

			_storage.Breakfast = _addFood.Array;
			_addFood.Clear();
			_addFood.Array = _storage.Lunch;
			break;
		case 2:
			_animLunch.Play("LunchOut");
			_animDinner.Play("DinnerIn");

			_storage.Lunch = _addFood.Array;
			_addFood.Clear();
			_addFood.Array = _storage.Dinner;
			break;
		case 3:
			_animDinner.Play("DinnerOut");
			_animSnack.Play("SnackIn");

			_storage.Dinner = _addFood.Array;
			_addFood.Clear();
			_addFood.Array = _storage.Snack;
			break;
		case 4:
			_animBreakfast.Play("BreakFastIn");
			_animLunch.Play("LunchOut");

			_storage.Lunch = _addFood.Array;
			_addFood.Clear();
			_addFood.Array = _storage.Breakfast;
			break;
		case 5:
			_animLunch.Play("LunchIn");
			_animDinner.Play("DinnerOut");

			_storage.Dinner = _addFood.Array;
			_addFood.Clear();
			_addFood.Array = _storage.Lunch;
			break;
		case 6:
			_animDinner.Play("DinnerIn");
			_animSnack.Play("SnackOut");

			_storage.Snack = _addFood.Array;
			_addFood.Clear();
			_addFood.Array = _storage.Dinner;
			break;
		}
	}
}
