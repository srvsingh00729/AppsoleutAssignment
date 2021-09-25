using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//To Force Preset Controls In Graphics Menu


public class PresetApplication : MonoBehaviour
{
	
	[SerializeField] private Toggle AutomaticPresetToggle, LowPresetToggle, MediumPresetToggle, HighPresetToggle, AdvancedPresetToggle, CustomPresetToggle;
	[SerializeField] private Toggle OnVsyncToggle, OffVsyncToggle;
	[SerializeField] private Toggle TwoxPresetToggle, FourxPresetToggle, OffPresetToggle;
	[SerializeField] private Toggle ShadowLow, ShadowMid, ShadowHigh, ShadowOff;
	[SerializeField] private Toggle OnReflectionToggle, OffReflectionToggle;
	public Slider ResolutionSlider;
	public Slider ShadowSlider;
	public Slider DrawDistanceSlider;

	
    // Start is called before the first frame update
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(AutomaticPresetToggle.isOn)
		{
			OffVsyncToggle.isOn = true;
			ShadowMid.isOn = true;
			TwoxPresetToggle.isOn = true;
			OffReflectionToggle.isOn = true;
			ResolutionSlider.value = 60;
			ShadowSlider.value = 60;
			DrawDistanceSlider.value = 60;
			
		}
		
		if(LowPresetToggle.isOn)
		{
			OffVsyncToggle.isOn = true;
			ShadowMid.isOn = false;
			OffPresetToggle.isOn = true;
			OffReflectionToggle.isOn = true;
			ResolutionSlider.value = 20;
			ShadowSlider.value = 20;
			DrawDistanceSlider.value = 20;
			
		}
		
		if(MediumPresetToggle.isOn)
		{
			OffVsyncToggle.isOn = false;
			ShadowMid.isOn = true;
			TwoxPresetToggle.isOn = true;
			OffReflectionToggle.isOn = false;
			ResolutionSlider.value = 60;
			ShadowSlider.value = 75;
			DrawDistanceSlider.value = 75;
			
		}
		
		if(HighPresetToggle.isOn)
		{
			OffVsyncToggle.isOn = false;
			ShadowMid.isOn = true;
			FourxPresetToggle.isOn = true;
			OffReflectionToggle.isOn = false;
			ResolutionSlider.value = 75;
			ShadowSlider.value = 75;
			DrawDistanceSlider.value = 75;
			
		}
		
		if(AdvancedPresetToggle.isOn)
		{
			OffVsyncToggle.isOn = false;
			ShadowMid.isOn = true;
			FourxPresetToggle.isOn = true;
			OffReflectionToggle.isOn = false;
			ResolutionSlider.value = 100;
			ShadowSlider.value = 100;
			DrawDistanceSlider.value = 100;
			
		}
		
		
    }
}
