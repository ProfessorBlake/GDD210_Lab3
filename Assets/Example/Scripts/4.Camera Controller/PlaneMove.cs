using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMove : MonoBehaviour
{
	public float Speed;
	private float yTarget = 0f; //Altitude our plane should try to reach.
	private Vector3 moveVector; //Direction plane is heading.
    
    void Update()
    {
		moveVector = new Vector3(2, yTarget - transform.position.y, 0f).normalized; //Set direction of movement, using .normalized to scale max length to 1.
		transform.position += moveVector * Speed; //Move our plane in it's moveVector direction * our speed.

		if(Random.value > 0.99f)
		{
			yTarget = Random.Range(-3f, 1f); //Randomly assign a new target altitude.
		}
    }
}
