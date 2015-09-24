using UnityEngine;
using System.Collections;
public class ConventionsAndSyntaxScript : MonoBehaviour

{ 
	int cube = 7;
	int SplatterWarning = 10;	

		//This is a single line comment.
			
			/* This is a multiple line comment or block 
				of code that needs to be commented out.
			*/
	
	void Update()
	{
		//The following line of code is used to track the position on the falling cube. Enter the correct convention.
			Debug.Log (transform.position);
		
		/*The following statement will tell unity when to print "I'm going to splater!" to the console if the cube is < or = 10. 
			Enter the correct statement.
		*/

		if (cube < SplatterWarning) 
		{
			Debug.Log ("I'm going to splater!");
		} 
		else if (cube == SplatterWarning)
		{
			Debug.Log ("I'm going to splatter!");
		}
	
	}
}