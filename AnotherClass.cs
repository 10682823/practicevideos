using UnityEngine;
using System.Collections;

public class AnotherClass
{
	public int apples;
	public int bananas;


	private int stapler;
	private int paper;


	public void FruitMachine (int a, int b)
	{
		int answer;
		answer = a + b;
		Debug.Log("Fruit total: " + answer);
	}


	private void OfficeSort (int a, int b)
	{
		int answer;
		answer = a + b;
		Debug.Log("Supplies total: " + answer);
	}
}