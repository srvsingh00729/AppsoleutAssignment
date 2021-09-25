using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class TextColorChange : MonoBehaviour
{
	[SerializeField] Color DefaultTextColor;
	[SerializeField] Color ClickedTextColor;

	public Toggle Toggle; 
	[SerializeField] TextMeshProUGUI Text;

	private void OnEnable()
	{
		ChangeToggleText();
	}

	public void ChangeToggleText()
	{
		if (GetComponent<Toggle>().isOn)
		{
			Text.color = ClickedTextColor;
			
		}

		else
		{
			Text.color = DefaultTextColor;

		}
	}
}
