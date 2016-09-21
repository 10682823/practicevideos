using UnityEngine;
using System.Collections;

public class ForEachLoop : MonoBehaviour 
{   
	void Start () 
	{
		string[] strings = new string[3];

		strings[0] = "string one";
		strings[1] = "string two";
		strings[2] = "string three";

		foreach(string item in strings)
		{
			print (item);
		}
	}
}