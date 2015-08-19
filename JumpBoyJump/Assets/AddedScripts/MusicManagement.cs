using UnityEngine;
using System.Collections;

public class MusicManagement : MonoBehaviour {

	private AudioSource _mySource;
	private float _volume = 1.0f;
	
	private static MusicManagement _instance = null;

	public static MusicManagement Instance 
	{
		get { return _instance; }
	}

	void Awake() 
	{
		if (_instance != null && _instance != this) 
		{
			Destroy(this.gameObject);
			return;
		} 
		else 
		{
			_instance = this;
		}
		DontDestroyOnLoad(this.gameObject);
	}

	void Start () 
	{
		_mySource = GetComponent<AudioSource>();
	}

	void Update () 
	{
		_mySource.volume = _volume;
	}

	public void UpdateAdjusment (float NewVolume) 
	{
		_volume = NewVolume;
		_mySource.volume = _volume;
	}

	public void AdjustVolume(float NewVolume)
	{
		_volume = NewVolume;
	}
}
