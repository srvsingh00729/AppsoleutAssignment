using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//TO Save Antialiasing Toggle Group Data 

public class SaveAntialiasing : MonoBehaviour
{
    [SerializeField] private Toggle TwoxPresetToggle, FourxPresetToggle, OffPresetToggle;
	
	private void Awake() 
	{
		if(PlayerPrefs.GetInt("AntialiasingToggle") == 0)
		{
			TwoxPresetToggle.isOn = true;
			FourxPresetToggle.isOn = false;
			OffPresetToggle.isOn = false;
		}
		else if(PlayerPrefs.GetInt("AntialiasingToggle") == 1)
		{
			TwoxPresetToggle.isOn = false;
			FourxPresetToggle.isOn = true;
			OffPresetToggle.isOn = false;
		}
		else if(PlayerPrefs.GetInt("AntialiasingToggle") == 2)
		{
			TwoxPresetToggle.isOn = false;
			FourxPresetToggle.isOn = false;
			OffPresetToggle.isOn = true;
		}
		
	}
	
	public void TwoxPresetToggleSelected()
	{
		PlayerPrefs.SetInt("AntialiasingToggle",0);
	}
	
	public void FourxPresetToggleSelected()
	{
		PlayerPrefs.SetInt("AntialiasingToggle",1);
	}
	
	public void OffPresetToggleSelected()
	{
		PlayerPrefs.SetInt("AntialiasingToggle",2);
	}
	
	
	
}
