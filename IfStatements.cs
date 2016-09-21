using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour
{
	float weatherTemperature = 95.0f;
	float hotLimitTemperature = 60.0f;
	float coldLimitTemperature = 30.0f;


	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Space))
			TemperatureTest();

		weatherTemperature -= Time.deltaTime * 5f;
	}


	void TemperatureTest ()
	{

		if(weatherTemperature > hotLimitTemperature)
		{
			// ... do this.
			print("The weather is too hot.");
		}

		else if(weatherTemperature < coldLimitTemperature)
		{
			// ... do this.
			print("The weather is too cold.");
		}

		else
		{
			// ... do this.
			print("The weather is perfect.");
		}
	}
}