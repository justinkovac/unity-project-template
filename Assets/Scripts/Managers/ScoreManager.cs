using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {
	private static ScoreManager _instance;	
	public static ScoreManager instance
	{
		get
		{
			if(_instance == null)
				_instance = GameObject.FindObjectOfType<ScoreManager>();
			return _instance;
		}
	}
	
	void Update () {
		
		
	}
}