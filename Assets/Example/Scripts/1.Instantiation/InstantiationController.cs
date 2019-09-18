using UnityEngine;

public class InstantiationController : MonoBehaviour
{
	public GameObject[] BallPrefabs;
	public Camera Cam;

	private void Update()
	{
		//Get the mouse position so we can instantiate our prefabs there.
		//This works by converting the position of the mouse on the screen to a position in the scene.
		Vector3 position = Cam.ScreenToWorldPoint(Input.mousePosition);
		position.z = 0f; //Set z position to 0.

		//Left mouse button will instantiate the prefab in BallPrefabs at index 0.
		//Instantiate needs a GameObject to copy (our prefab), a position to place it, and a rotation. Quaternion.Identity is the default rotation.
		if (Input.GetMouseButtonDown(0))
		{
			Instantiate(BallPrefabs[0], position, Quaternion.identity);
		}

		//Right mouse button will instantiate the prefab in BallPrefabs at index 1;
		if (Input.GetMouseButtonDown(1))
		{
			Instantiate(BallPrefabs[1], position, Quaternion.identity);
		}

		//Middle mouse button will instantiate a random prefab from the array.
		if (Input.GetMouseButtonDown(2))
		{
			Instantiate(BallPrefabs[Random.Range(0, BallPrefabs.Length)], position, Quaternion.identity);
		}
	}
}
