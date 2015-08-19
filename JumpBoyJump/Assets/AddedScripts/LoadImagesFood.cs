using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.IO;

public class LoadImagesFood : MonoBehaviour {

	private Texture2D[] _images;

	public Texture2D[] Images
	{
		get{return _images;}
	}

	public LoadImagesFood()
	{
		int count = 0;
		int j = 0;

		DirectoryInfo directory = new DirectoryInfo ("Assets/Resources/Images/Buttons/FoodButtons/Foods/");
		FileInfo[] fileInfo = directory.GetFiles ();

		foreach(FileInfo f in fileInfo)
		{
			if (f.Extension.Contains("png"))
				count++;
		}

		_images = new Texture2D[count];

		for(int i = 0; i < fileInfo.Length; i++){
			if(fileInfo[i].Extension.Contains("png"))
			{
				_images[j] = Resources.Load("Images/Buttons/FoodButtons/Foods/" + Path.GetFileNameWithoutExtension(fileInfo[i].Name))as Texture2D;
				j++;
			}
		}

		//_images[0] = Resources.Load("Images/Buttons/FoodButtons/Foods/jump_boy_jump_food_apple") as Texture2D;
	}

}
