using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//To Save All Slider Data In Graphics Menu

public class SaveSlider : MonoBehaviour
{
	
	public Slider ResolutionSlider;
	public Slider ShadowSlider;
	public Slider DrawDistanceSlider;
	public float ResolutionSliderValue;
	public float ShadowSliderValue;
	public float DrawDistanceSliderValue;
    // Start is called before the first frame update
    void Start()
    {
        ResolutionSlider.value = PlayerPrefs.GetFloat("ResolutionSliderSave",ResolutionSliderValue);
		ShadowSlider.value = PlayerPrefs.GetFloat("ShadowSliderSave",ShadowSliderValue);
        DrawDistanceSlider.value = PlayerPrefs.GetFloat("DrawDistanceSliderSave",DrawDistanceSliderValue);

    }

    public void SaveResolution( float value )
    {
        ResolutionSliderValue = value;
		PlayerPrefs.SetFloat("ResolutionSliderSave",ResolutionSliderValue);
    }
	
	public void SaveShadow( float value )
    {
        ShadowSliderValue = value;
		PlayerPrefs.SetFloat("ShadowSliderSave",ShadowSliderValue);
    }
	
	public void SaveDrawDistance( float value )
    {
        DrawDistanceSliderValue = value;
		PlayerPrefs.SetFloat("DrawDistanceSliderSave",DrawDistanceSliderValue);
    }
	
}
