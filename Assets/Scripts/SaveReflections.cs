using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//To Save Reflections Toggle Group Data

public class SaveReflections : MonoBehaviour
{
    [SerializeField] private Toggle OnPresetToggle, OffPresetToggle;
	
	private void Awake() 
	{
		if(PlayerPrefs.GetInt("ReflectionsToggle") == 0)
		{
			OnPresetToggle.isOn = true;
			OffPresetToggle.isOn = false;
		}
		else if(PlayerPrefs.GetInt("ReflectionsToggle") == 1)
		{
			OnPresetToggle.isOn = false;
			OffPresetToggle.isOn = true;
		}
		
	}
	
	public void OnPresetToggleSelected()
	{
		PlayerPrefs.SetInt("ReflectionsToggle",0);
	}
	
	public void OffPresetToggleSelected()
	{
		PlayerPrefs.SetInt("ReflectionsToggle",1);
	}
	
	
	
	


}
