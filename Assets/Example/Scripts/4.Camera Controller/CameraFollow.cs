using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	public Transform Target; //The transform component of our plane.
	public float LerpSpeed; //How quickly to interpolate the camera's position.

	private void LateUpdate()
	{
		Vector3 targetPosition = new Vector3(Target.position.x, Target.position.y, transform.position.z); //Where the camera is trying to go.

		transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * LerpSpeed);
		//The Lerp() function will use linear interpolation to smooth out the movement of the camera.
		//A simple example of this would be using it to find half way between two numbers: Half way between 2 and 4.
		//	- The Lerp function for floats can be found in the Mathf class.
		//	- Matf.Lerp(2, 4, 0.5f);
		//	- This will return 3, or 0.5 between 2 and 4.
		//With Vector3.Lerp(), we pass in our current position and the position we want to go. Then we move at our LerpSpeed.
	}
}
