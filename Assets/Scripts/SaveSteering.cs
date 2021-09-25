using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SaveSteering : MonoBehaviour
{
    [SerializeField] private Toggle SteeringPresetToggle, TouchpadPresetToggle, TiltPresetToggle;
	
	private void Awake() 
	{
		if(PlayerPrefs.GetInt("SteeringToggle") == 0)
		{
			SteeringPresetToggle.isOn = true;
			TouchpadPresetToggle.isOn = false;
			TiltPresetToggle.isOn = false;
		}
		else if(PlayerPrefs.GetInt("SteeringToggle") == 1)
		{
			SteeringPresetToggle.isOn = false;
			TouchpadPresetToggle.isOn = true;
			TiltPresetToggle.isOn = false;
		}
		else if(PlayerPrefs.GetInt("SteeringToggle") == 2)
		{
			SteeringPresetToggle.isOn = false;
			TouchpadPresetToggle.isOn = false;
			TiltPresetToggle.isOn = true;
		}
		
	}
	
	public void SteeringPresetToggleSelected()
	{
		PlayerPrefs.SetInt("SteeringToggle",0);
	}
	
	public void TouchpadPresetToggleSelected()
	{
		PlayerPrefs.SetInt("SteeringToggle",1);
	}
	
	public void TiltPresetToggleSelected()
	{
		PlayerPrefs.SetInt("SteeringToggle",2);
	}
	
	
	
}
