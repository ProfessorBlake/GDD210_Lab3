using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleExample : MonoBehaviour
{
	public Transform CrateTransform;

	private bool spinning;

	private void Update()
	{
		if(spinning)
		{
			CrateTransform.eulerAngles += new Vector3(0f, 0f, Time.deltaTime * 100f);
		}
	}

	//This uses a "Dynamic" bool, which means the UI component that calls it automatically passes it's value
	//as the spin parameter. So when the box is checked, spin will be true.
	public void SpinBox(bool spin)
	{
		spinning = spin;
	}
}
