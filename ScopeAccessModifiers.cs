using UnityEngine;
using System.Collections;

public class ScopeAccessModifiers : MonoBehaviour
{
	public int one = 5;


	private int two = 0;
	private int three = 5;


	private AnotherClass myOtherClass;


	void Start ()
	{
		one = 29;

		myOtherClass = new AnotherClass();
		myOtherClass.FruitMachine(one, myOtherClass.apples);
	}


	void Example (int pens, int crayons)
	{
		int answer;
		answer = pens * crayons * one;
		Debug.Log(answer);
	}


	void Update ()
	{
		Debug.Log("One is set to: " + one);
	}
}
