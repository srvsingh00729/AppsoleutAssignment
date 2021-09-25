using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//To Save Sound And Music Toggles

public class SaveAudioToggle : MonoBehaviour
{
    [SerializeField] private Toggle SoundPresetToggle;
	public int toggleFlag = 0;
	
	public void Awake() 
	{
		toggleFlag = PlayerPrefs.GetInt("AudioToggle");
		if(toggleFlag == 1)
		{
			SoundPresetToggle.isOn = true;
		}
		else
			SoundPresetToggle.isOn = false;
	}
	
	
	
	public void UpdateToggle()
	{		
		if(SoundPresetToggle.isOn)
			toggleFlag = 1;
		
		else
			toggleFlag = 0;
		
		PlayerPrefs.SetInt("AudioToggle",toggleFlag);
	}
	


}
