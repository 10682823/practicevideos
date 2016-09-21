using UnityEngine;
using System.Collections;

public class Convention : MonoBehaviour
{
	void Start ()
	{
		//this is used to tell me the x position of my object
		Debug.Log(transform.position.x);

		if(transform.position.y <= 9f)
		{
			Debug.Log ("ground");
		}
	}
}