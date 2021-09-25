using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveHandcontrols : MonoBehaviour
{
    [SerializeField] private Toggle LeftPresetToggle, RightPresetToggle;
	
	private void Awake() 
	{
		if(PlayerPrefs.GetInt("HandToggle") == 0)
		{
			LeftPresetToggle.isOn = true;
			RightPresetToggle.isOn = false;
		}
		else if(PlayerPrefs.GetInt("HandToggle") == 1)
		{
			LeftPresetToggle.isOn = false;
			RightPresetToggle.isOn = true;
		}
		
	}
	
	public void LeftPresetToggleSelected()
	{
		PlayerPrefs.SetInt("HandToggle",0);
	}
	
	public void RightPresetToggleSelected()
	{
		PlayerPrefs.SetInt("HandToggle",1);
	}
	
	
	
	


}
