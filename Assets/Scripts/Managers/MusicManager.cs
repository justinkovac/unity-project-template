using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {
	private static MusicManager _instance;	
	public static MusicManager instance
	{
		get
		{
			if(_instance == null)
				_instance = GameObject.FindObjectOfType<MusicManager>();
			return _instance;
		}
	}


	
	void Update () {
		
		
	}
}
