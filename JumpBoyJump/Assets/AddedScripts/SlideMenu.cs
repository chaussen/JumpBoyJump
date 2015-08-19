using UnityEngine;
using System.Collections;

public class SlideMenu : MonoBehaviour {

	
	
	/*public float minSwipeDistY;
	
	public float minSwipeDistX;
	
	private Vector2 startPos;

	//public GameObject button;

	private Rigidbody2D _rigidBody;
	// Use this for initialization
	void Start () {
		
		//_rigidBody = button.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) 
		{
			
			Touch touch = Input.touches[0];

			switch (touch.phase) 
				
			{
				
			case TouchPhase.Began:
				startPos = touch.position;
				break;
			case TouchPhase.Ended:

				float swipeDistHorizontal = (new Vector3(touch.position.x,0, 0) - new Vector3(startPos.x, 0, 0)).magnitude;
				
				if (swipeDistHorizontal > minSwipeDistX) 
				{
					float swipeValue = Mathf.Sign(touch.position.x - startPos.x);
					
					if (swipeValue > 0){_rigidBody.AddTorque(1f);}//right swipe
						
						//MoveRight ();
					else if (swipeValue < 0){_rigidBody.AddForce(new Vector2(1f,0f));}//left swipe
							
							//MoveLeft ();
							
				}
				break;
			}
		}

	}*/
}
