using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderExample : MonoBehaviour
{
	public Slider Slider;
	public Text Text;

	public void UpdateText()
	{
		Text.text = Slider.value.ToString();
		Text.color = Color.Lerp(Color.blue, Color.red, Slider.value);
	}
}
