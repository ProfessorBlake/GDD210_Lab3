using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputExample : MonoBehaviour
{
	public Text Greeting;

	//This uses a "Dynamic" string, which means the UI component that calls it automatically passes it's value
	//as the name parameter.
	public void UpdateText(string name)
	{
		Greeting.text = "Nice to meet you " + name;
	}
}
