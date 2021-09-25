using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//To Save VSync Toggle Group Data

public class SaveVsync : MonoBehaviour
{
    [SerializeField] private Toggle OnPresetToggle, OffPresetToggle;
	
	private void Awake() 
	{
		if(PlayerPrefs.GetInt("VsyncToggle") == 0)
		{
			OnPresetToggle.isOn = true;
			OffPresetToggle.isOn = false;
		}
		else if(PlayerPrefs.GetInt("VsyncToggle") == 1)
		{
			OnPresetToggle.isOn = false;
			OffPresetToggle.isOn = true;
		}
		
	}
	
	public void OnPresetToggleSelected()
	{
		PlayerPrefs.SetInt("VsyncToggle",0);
	}
	
	public void OffPresetToggleSelected()
	{
		PlayerPrefs.SetInt("VsyncToggle",1);
	}
	
	
	
	


}
