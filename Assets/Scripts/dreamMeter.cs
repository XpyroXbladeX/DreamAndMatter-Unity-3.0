using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dreamMeter : MonoBehaviour 
{
	/*PSEUDOCODING AT ITS BEST~~~*/
	//This is Quira's attempt at trying to figure out the gauge bar (or dreamMeter) for the game 

	//Relate this script to the pickup items

	//Starting off, this meter should be at max health, but should be constantly changing, either lower or higher 
	int dreamer = 20; 


	void Start () 
	{
		Debug.Log("Yay for sweet dreams");
	}
	

	void Update () 
	{

		//IF pickup items are not being collected, dreamer will drop by 1 every 2 seconds
		/*if (dreamMatter != true) //dreamMatter is from the class (whatever is used for pickups) which represents the pickup objects
		{
			//the dream meter is being threatened, so we need a representation of that 
			dreamer--; 
			Debug.Log ("Ouch that hurts");
		}*/

		if (dreamer <= 10)
		{
			//Representation of the nightmare mode due to the gauge dropping too low
			Debug.Log ("Whoa what's happening to me?");
		}
	}
}
