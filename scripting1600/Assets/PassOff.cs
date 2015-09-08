using UnityEngine;
using System.Collections;

public class PassOff : MonoBehaviour
{

	int Int1 = 676;
	void Start ()
	{
		Int1 = SubtractTen (Int1);
		Debug.Log (Int1);
	}
		int SubtractTen(int Number){
		int ret;
		ret = Number - 10;
			return ret;
	}
	void Update ()
	{
	
	}
}

