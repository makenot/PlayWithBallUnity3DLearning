using UnityEngine;
using System.Collections;
using System.Timers;
using AssemblyCSharp;

public class BallSpamBehavior : MonoBehaviour {
	public GameObject ballprefab;
	// Use this for initialization
	private  float timeToSpam=10;
	private  float _currnentTime =0f;
	void Start () {
	
	
	
	}

	void spam(object sender, ElapsedEventArgs args){
		Instantiate (ballprefab);
	}
	// Update is called once per frame
	void Update () {
		_currnentTime += Time.deltaTime; 
		Debug.Log("_currnentTime:"+_currnentTime);
		if(timeToSpam<_currnentTime)
		{

			_currnentTime=0;
			spam(this,null);
			Debug.Log("should spam");

		}
	}

}
