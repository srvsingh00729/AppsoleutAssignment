using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//To Save Presets Toggle Group Data

public class SavePreset : MonoBehaviour
{
	[SerializeField] private Toggle AutomaticPresetToggle, LowPresetToggle, MediumPresetToggle, HighPresetToggle, AdvancedPresetToggle, CustomPresetToggle;
	
	private void Awake() 
	{
		
		if(PlayerPrefs.GetInt("PresetsToggle") == 0)
		{
			AutomaticPresetToggle.isOn = true;
			LowPresetToggle.isOn = false;
			MediumPresetToggle.isOn = false;
			HighPresetToggle.isOn = false;
			AdvancedPresetToggle.isOn = false;
			CustomPresetToggle.isOn = false;
		}
		else if(PlayerPrefs.GetInt("PresetsToggle") == 1)
		{
			AutomaticPresetToggle.isOn = false;
			LowPresetToggle.isOn = true;
			MediumPresetToggle.isOn = false;
			HighPresetToggle.isOn = false;
			AdvancedPresetToggle.isOn = false;
			CustomPresetToggle.isOn = false;
		}
		else if(PlayerPrefs.GetInt("PresetsToggle") == 2)
		{
			AutomaticPresetToggle.isOn = false;
			LowPresetToggle.isOn = false;
			MediumPresetToggle.isOn = true;
			HighPresetToggle.isOn = false;
			AdvancedPresetToggle.isOn = false;
			CustomPresetToggle.isOn = false;
		}
		else if(PlayerPrefs.GetInt("PresetsToggle") == 3)
		{
			AutomaticPresetToggle.isOn = false;
			LowPresetToggle.isOn = false;
			MediumPresetToggle.isOn = false;
			HighPresetToggle.isOn = true;
			AdvancedPresetToggle.isOn = false;
			CustomPresetToggle.isOn = false;
		}
		else if(PlayerPrefs.GetInt("PresetsToggle") == 4)
		{
			AutomaticPresetToggle.isOn = false;
			LowPresetToggle.isOn = false;
			MediumPresetToggle.isOn = false;
			HighPresetToggle.isOn = false;
			AdvancedPresetToggle.isOn = true;
			CustomPresetToggle.isOn = false;
		}
		else if(PlayerPrefs.GetInt("PresetsToggle") == 5)
		{
			AutomaticPresetToggle.isOn = false;
			LowPresetToggle.isOn = false;
			MediumPresetToggle.isOn = false;
			HighPresetToggle.isOn = false;
			AdvancedPresetToggle.isOn = false;
			CustomPresetToggle.isOn = true;
		}
    }
	
	public void AutomaticPresetToggleSelected()
	{
		PlayerPrefs.SetInt("PresetsToggle",0);
	}
	
	public void LowPresetToggleSelected()
	{
		PlayerPrefs.SetInt("PresetsToggle",1);
	}
	
	public void MediumPresetToggleSelected()
	{
		PlayerPrefs.SetInt("PresetsToggle",2);
	}
	
	public void HighPresetToggleSelected()
	{
		PlayerPrefs.SetInt("PresetsToggle",3);
	}
	
	public void AdvancedPresetToggleSelected()
	{
		PlayerPrefs.SetInt("PresetsToggle",4);
	}
	
	public void CustomPresetToggleSelected()
	{
		PlayerPrefs.SetInt("PresetsToggle",5);
	}
	
}
