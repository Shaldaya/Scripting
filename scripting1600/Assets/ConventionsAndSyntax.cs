using UnityEngine;
using System.Collections;

public class BasicSyntax : MonoBehaviour
{
	void Start ()
	{
		Debug.Log(transform.position.x);

		if(transform.position.y <= 250f)
		{
			Debug.Log ("wow!");
		}
	}
}
//Dot operator, semicolon- when its needed, Curley brackets- indenting, Comments- mulit line