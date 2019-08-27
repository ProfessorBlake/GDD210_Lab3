using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
	public GameObject BallPrefab;
	public float BallStartYPosition;
	public float BallStartXRange;
	public Vector3 BoomPosition;
	public float BoomPower;
	public float BoomFalloff;

	private List<GameObject> ballList = new List<GameObject>();

    public void Button_Drop()
	{
		for (int i = 0; i < 10f; i++)
		{
			GameObject newBall = Instantiate(BallPrefab, new Vector3(Random.Range(-BallStartXRange, BallStartXRange), BallStartYPosition, 0f), Quaternion.identity);
			ballList.Add(newBall);
		}
	}

	public void Button_Clear()
	{
		foreach(GameObject ball in ballList)
		{
			Destroy(ball);
		}
		ballList.Clear();
	}

	public void Button_Boom()
	{
		foreach (GameObject ball in ballList)
		{
			float distanceFromBoom = Vector2.Distance(ball.transform.position, BoomPosition);
			ball.GetComponent<Rigidbody2D>().AddForceAtPosition((ball.transform.position- BoomPosition).normalized / (distanceFromBoom * BoomFalloff) * BoomPower, BoomPosition);
		}
	}
}
