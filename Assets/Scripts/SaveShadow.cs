using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//To Save Shadow Toggle Group Data


public class SaveShadow : MonoBehaviour
{
    [SerializeField] private Toggle LowPresetToggle, MediumPresetToggle, HighPresetToggle, OffPresetToggle;
	
	private void Awake() 
	{
		if(PlayerPrefs.GetInt("ShadowToggle") == 0)
		{
			LowPresetToggle.isOn = true;
			MediumPresetToggle.isOn = false;
			HighPresetToggle.isOn = false;
			OffPresetToggle.isOn = false;
		}
		else if(PlayerPrefs.GetInt("ShadowToggle") == 1)
		{
			LowPresetToggle.isOn = false;
			MediumPresetToggle.isOn = true;
			HighPresetToggle.isOn = false;
			OffPresetToggle.isOn = false;
		}
		else if(PlayerPrefs.GetInt("ShadowToggle") == 2)
		{
			LowPresetToggle.isOn = false;
			MediumPresetToggle.isOn = false;
			HighPresetToggle.isOn = true;
			OffPresetToggle.isOn = false;
		}
		else if(PlayerPrefs.GetInt("ShadowToggle") == 3)
		{
			LowPresetToggle.isOn = false;
			MediumPresetToggle.isOn = false;
			HighPresetToggle.isOn = false;
			OffPresetToggle.isOn = true;
		}
	}
	
	public void LowPresetToggleSelected()
	{
		PlayerPrefs.SetInt("ShadowToggle",0);
	}
	
	public void MediumPresetToggleSelected()
	{
		PlayerPrefs.SetInt("ShadowToggle",1);
	}
	
	public void HighPresetToggleSelected()
	{
		PlayerPrefs.SetInt("ShadowToggle",2);
	}
	
	public void OffPresetToggleSelected()
	{
		PlayerPrefs.SetInt("ShadowToggle",3);
	}
	
	
}
