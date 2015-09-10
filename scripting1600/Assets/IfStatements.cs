using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour 


{
	public float weather = 85.0f;
	public float weatherHighLimit = 90.0f;
	public float weatherLowLimit = 60.0f;

		void Update ()
		{
			if(Input.GetKeyDown(KeyCode.Space))
			TemperatureTest();
			weather -= Time.deltaTime * 5f;
		}

		void TemperatureTest ()
	
		{
			if (weather > weatherHighLimit)
			{
				print ("its too hot to go for a walk");
			} 
			else if (weather < weatherLowLimit)
			{
				print ("its too cold to go for for a walk");
			} 
			else
			{
				print ("The weather is perfect for a walk");
			}
		}
}
