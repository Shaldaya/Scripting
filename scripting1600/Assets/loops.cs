using UnityEngine;
using System.Collections;

public class loops : MonoBehaviour
{
	int numEnemies = 3;
	int cupsInTheSink = 4;

	void Start ()
		//while loop
	{
		while (cupsInTheSink > 0)
		{
			Debug.Log ("I've washed a cup!");
			cupsInTheSink--;
		}

		//for loop
		for (int i = 0; i < numEnemies; i++) 
		{
			Debug.Log ("Creating enemy number: " + i);
		}
		//doWhileLoop
		bool shouldContinue = false;
		do
		{
			print ("Hello World");
		}
		while(shouldContinue == true);
		//foreachloop
		string[] strings = new string[3];
		
		strings[0] = "First string";
		strings[1] = "Second string";
		strings[2] = "Third string";
		
		foreach(string item in strings)
		{
			print (item);
		}
	}
}