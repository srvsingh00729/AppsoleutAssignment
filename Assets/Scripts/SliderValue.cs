using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SliderValue : MonoBehaviour
{
	[SerializeField] public Slider Slider;
	[SerializeField] public Text Text;
	
    void Awake()
    {
        Slider.onValueChanged.AddListener((v) => {Text.text = v.ToString("0") + "%";});
    }

}
