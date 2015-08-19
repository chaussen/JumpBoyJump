using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class AddFood : MonoBehaviour {

	private LoadImagesFood _resource;
	private List<Texture2D> _array;
	private float defaultWidth;
	private float defaultHeight;
	private float ratioWidth;
	private float ratioHeight;
	
	public List<Texture2D> Array
	{
		get{return _array;}
		set{_array = value;}
	}

	void Start () {
		_resource = new LoadImagesFood ();
		_array = new List<Texture2D> ();

		defaultWidth = 800f;
		defaultHeight = 600f;

		ratioWidth = Screen.width / defaultWidth;
		ratioHeight = Screen.height / defaultHeight;

		Debug.Log (Screen.width + "x" + Screen.height);
		Debug.Log (ratioWidth + "x" + ratioHeight);
	}
	public void FoodToAdd(int foodValue)
	{
		_array.Add(_resource.Images[foodValue]);
	}

	public void Clear()
	{
		_array = new List<Texture2D> ();
	}

	void OnGUI ()
	{

		/*float xPos = 100f * ratioWidth;
		float yPos = 470f * ratioHeight;
		
		foreach (Texture2D t in _array) {
			Rect r = new Rect(xPos, yPos, 50, 50);
			Graphics.DrawTexture (r, t);
			
			if (Input.GetMouseButton(0))
				if(r.Contains(Event.current.mousePosition)) 
					_array.Remove (t);
			if (Input.GetTouch(0).phase == TouchPhase.Ended && Input.touchCount > 0)
				if(r.Contains(Event.current.mousePosition)) 
					_array.Remove (t);
			
			xPos += 50f;
			
			if (xPos == (800f * ratioWidth)) {
				xPos = 100f * ratioWidth;
				yPos += 50f;
			}
		}*/

		/*float xPos = 100f * ratioWidth;
		float yPos = 470f * ratioHeight;



		foreach (Texture2D t in _array) {
			if (GUI.Button (new Rect (xPos, yPos, 50, 50), t))
				_array.Remove (t);
			
			xPos += 50f;
			
			if (xPos > (800f * ratioWidth)) {
				xPos = 100f * ratioWidth;
				yPos += 50f;
			}
		}*/

		float xPos = Screen.width * 0.1f;
		float yPos = Screen.height * 0.78f;
		
		
		
		foreach (Texture2D t in _array) {
			if (GUI.Button (new Rect (xPos, yPos, 50, 50), t))
				_array.Remove (t);
			
			xPos += 50f;
			
			if (xPos > (Screen.width * 0.75f)) {
				xPos = Screen.width * 0.1f;
				yPos += 50f;
			}
		}

	}
}
