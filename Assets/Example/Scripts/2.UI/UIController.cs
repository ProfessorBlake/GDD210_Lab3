using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
	public GameObject BallPrefab;
	public float BallStartYPosition; //Height to spawn balls.
	public float BallStartXRange;	//Width of random ball spawn position.
	public Vector3 BoomPosition;	//Point to add force from.
	public float BoomPower;			//Add force strength.
	public float BoomFalloff;		//Strength loss over distance.

	private List<GameObject> ballList = new List<GameObject>(); //List of all spawned balls.

	//This is called by the UI button.
    public void Button_Drop()
	{
		//For loop to spawn 10 balls per call.
		for (int i = 0; i < 10f; i++)
		{
			//Instantiate at a random position, and set to temp variable for future use.
			GameObject newBall = Instantiate(BallPrefab, new Vector3(Random.Range(-BallStartXRange, BallStartXRange), BallStartYPosition, 0f), Quaternion.identity);
			ballList.Add(newBall); //Use temp varaible to add ball to list.
		}
	}

	public void Button_Clear()
	{
		//For each loop.
		foreach(GameObject ball in ballList)
		{
			Destroy(ball); //Destroy each ball in the list.
		}
		ballList.Clear(); //Clear all balls from the list.
	}

	public void Button_Boom()
	{
		//Loop through each ball in the list.
		foreach (GameObject ball in ballList)
		{
			//Get this balls distance from the boom position.
			float distanceFromBoom = Vector2.Distance(ball.transform.position, BoomPosition);
			//Add a force to the ball, using it's distance to create a strength falloff.
			ball.GetComponent<Rigidbody2D>().AddForceAtPosition((ball.transform.position- BoomPosition).normalized / (distanceFromBoom * BoomFalloff) * BoomPower, BoomPosition);
			//(ball.transform.position- BoomPosition).normalized : This returns a Vector2 in the direction the explosion should push the ball.
			//	.normalized will scale the vector so that it's distance is 1.
		}
	}
}
