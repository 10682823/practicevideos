using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour 
{
	public int statement = 5;


	void Greet()
	{
		switch (statement)
		{
		case 5:
			print ("How is your day?");
			break;
		case 4:
			print ("What do you have planned for today?");
			break;
		case 3:
			print ("What a beautiful day!");
			break;
		case 2:
			print ("Why did I have to get up today?");
			break;
		case 1:
			print ("I want to leave work.");
			break;
		default:
			print ("Not a greeting.");
			break;
		}

	}
}