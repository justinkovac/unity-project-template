using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour {
	private static EnemyManager _instance;	
	public static EnemyManager instance
	{
		get
		{
			if(_instance == null)
				_instance = GameObject.FindObjectOfType<EnemyManager>();
			return _instance;
		}
	}
	
	void Update () {
		
		
	}
}