using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FoodStorage : MonoBehaviour {

	private List<Texture2D> _breakfast;
	private List<Texture2D> _lunch;
	private List<Texture2D> _dinner;
	private List<Texture2D> _snack;

	public List<Texture2D> Breakfast
	{
		get{return _breakfast;}
		set{ _breakfast = value;}
	}
	public List<Texture2D> Lunch
	{
		get{return _lunch;}
		set{ _lunch = value;}
	}
	public List<Texture2D> Dinner
	{
		get{return _dinner;}
		set{ _dinner = value;}
	}
	public List<Texture2D> Snack
	{
		get{return _snack;}
		set{ _snack = value;}
	}

	public FoodStorage()
	{
		_breakfast = new List<Texture2D> ();
		_lunch = new List<Texture2D> ();
		_dinner = new List<Texture2D> ();
		_snack = new List<Texture2D> ();
	}

}
