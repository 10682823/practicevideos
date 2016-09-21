using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour
{
	int baseballsHit = 4;


	void Start ()
	{
		while(baseballsHit > 0)
		{
			Debug.Log ("Home Run!");
			baseballsHit--;
		}
	}
}