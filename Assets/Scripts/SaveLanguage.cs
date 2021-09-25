using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveLanguage : MonoBehaviour
{
	[SerializeField] private Toggle English, Chinese, Danish, French, German, Italian, Japanese, Dutch, Potugese, Russian, Arabic, Korean, Turkish, Spanish, Swedish, Vietnemese;
	private void Awake() 
	{
		if(PlayerPrefs.GetInt("LanguageToggle") == 0)
		{
			English.isOn = true;
			Chinese.isOn = false;
			Danish.isOn = false;
			French.isOn = false;
			German.isOn = false;
			Italian.isOn = false;
			Japanese.isOn = false;
			Dutch.isOn = false;
			Potugese.isOn = false;
			Russian.isOn = false;
			Arabic.isOn = false;
			Korean.isOn = false;
			Turkish.isOn = false;
			Spanish.isOn = false;
			Swedish.isOn = false;
			Vietnemese.isOn = false;
		}
		else if(PlayerPrefs.GetInt("LanguageToggle") == 1)
		{
			English.isOn = false;
			Chinese.isOn = true;
			Danish.isOn = false;
			French.isOn = false;
			German.isOn = false;
			Italian.isOn = false;
			Japanese.isOn = false;
			Dutch.isOn = false;
			Potugese.isOn = false;
			Russian.isOn = false;
			Arabic.isOn = false;
			Korean.isOn = false;
			Turkish.isOn = false;
			Spanish.isOn = false;
			Swedish.isOn = false;
			Vietnemese.isOn = false;
		}
		else if(PlayerPrefs.GetInt("LanguageToggle") == 2)
		{
			English.isOn = false;
			Chinese.isOn = false;
			Danish.isOn = true;
			French.isOn = false;
			German.isOn = false;
			Italian.isOn = false;
			Japanese.isOn = false;
			Dutch.isOn = false;
			Potugese.isOn = false;
			Russian.isOn = false;
			Arabic.isOn = false;
			Korean.isOn = false;
			Turkish.isOn = false;
			Spanish.isOn = false;
			Swedish.isOn = false;
			Vietnemese.isOn = false;
		}
		else if(PlayerPrefs.GetInt("LanguageToggle") == 3)
		{
			English.isOn = false;
			Chinese.isOn = false;
			Danish.isOn = false;
			French.isOn = true;
			German.isOn = false;
			Italian.isOn = false;
			Japanese.isOn = false;
			Dutch.isOn = false;
			Potugese.isOn = false;
			Russian.isOn = false;
			Arabic.isOn = false;
			Korean.isOn = false;
			Turkish.isOn = false;
			Spanish.isOn = false;
			Swedish.isOn = false;
			Vietnemese.isOn = false;
		}
		else if(PlayerPrefs.GetInt("LanguageToggle") == 4)
		{
			English.isOn = false;
			Chinese.isOn = false;
			Danish.isOn = false;
			French.isOn = false;
			German.isOn = true;
			Italian.isOn = false;
			Japanese.isOn = false;
			Dutch.isOn = false;
			Potugese.isOn = false;
			Russian.isOn = false;
			Arabic.isOn = false;
			Korean.isOn = false;
			Turkish.isOn = false;
			Spanish.isOn = false;
			Swedish.isOn = false;
			Vietnemese.isOn = false;
		}
		else if(PlayerPrefs.GetInt("LanguageToggle") == 5)
		{
			English.isOn = false;
			Chinese.isOn = false;
			Danish.isOn = false;
			French.isOn = false;
			German.isOn = false;
			Italian.isOn = true;
			Japanese.isOn = false;
			Dutch.isOn = false;
			Potugese.isOn = false;
			Russian.isOn = false;
			Arabic.isOn = false;
			Korean.isOn = false;
			Turkish.isOn = false;
			Spanish.isOn = false;
			Swedish.isOn = false;
			Vietnemese.isOn = false;
		}
		else if(PlayerPrefs.GetInt("LanguageToggle") == 6)
		{
			English.isOn = false;
			Chinese.isOn = false;
			Danish.isOn = false;
			French.isOn = false;
			German.isOn = false;
			Italian.isOn = false;
			Japanese.isOn = true;
			Dutch.isOn = false;
			Potugese.isOn = false;
			Russian.isOn = false;
			Arabic.isOn = false;
			Korean.isOn = false;
			Turkish.isOn = false;
			Spanish.isOn = false;
			Swedish.isOn = false;
			Vietnemese.isOn = false;
		}
		else if(PlayerPrefs.GetInt("LanguageToggle") == 7)
		{
			English.isOn = false;
			Chinese.isOn = false;
			Danish.isOn = false;
			French.isOn = false;
			German.isOn = false;
			Italian.isOn = false;
			Japanese.isOn = false;
			Dutch.isOn = true;
			Potugese.isOn = false;
			Russian.isOn = false;
			Arabic.isOn = false;
			Korean.isOn = false;
			Turkish.isOn = false;
			Spanish.isOn = false;
			Swedish.isOn = false;
			Vietnemese.isOn = false;
		}
		else if(PlayerPrefs.GetInt("LanguageToggle") == 8)
		{
			English.isOn = false;
			Chinese.isOn = false;
			Danish.isOn = false;
			French.isOn = false;
			German.isOn = false;
			Italian.isOn = false;
			Japanese.isOn = false;
			Dutch.isOn = false;
			Potugese.isOn = true;
			Russian.isOn = false;
			Arabic.isOn = false;
			Korean.isOn = false;
			Turkish.isOn = false;
			Spanish.isOn = false;
			Swedish.isOn = false;
			Vietnemese.isOn = false;
		}
		else if(PlayerPrefs.GetInt("LanguageToggle") == 9)
		{
			English.isOn = false;
			Chinese.isOn = false;
			Danish.isOn = false;
			French.isOn = false;
			German.isOn = false;
			Italian.isOn = false;
			Japanese.isOn = false;
			Dutch.isOn = false;
			Potugese.isOn = false;
			Russian.isOn = true;
			Arabic.isOn = false;
			Korean.isOn = false;
			Turkish.isOn = false;
			Spanish.isOn = false;
			Swedish.isOn = false;
			Vietnemese.isOn = false;
		}
		else if(PlayerPrefs.GetInt("LanguageToggle") == 10)
		{
			English.isOn = false;
			Chinese.isOn = false;
			Danish.isOn = false;
			French.isOn = false;
			German.isOn = false;
			Italian.isOn = false;
			Japanese.isOn = false;
			Dutch.isOn = false;
			Potugese.isOn = false;
			Russian.isOn = false;
			Arabic.isOn = true;
			Korean.isOn = false;
			Turkish.isOn = false;
			Spanish.isOn = false;
			Swedish.isOn = false;
			Vietnemese.isOn = false;
		}
		else if(PlayerPrefs.GetInt("LanguageToggle") == 11)
		{
			English.isOn = false;
			Chinese.isOn = false;
			Danish.isOn = false;
			French.isOn = false;
			German.isOn = false;
			Italian.isOn = false;
			Japanese.isOn = false;
			Dutch.isOn = false;
			Potugese.isOn = false;
			Russian.isOn = false;
			Arabic.isOn = false;
			Korean.isOn = true;
			Turkish.isOn = false;
			Spanish.isOn = false;
			Swedish.isOn = false;
			Vietnemese.isOn = false;
		}
		else if(PlayerPrefs.GetInt("LanguageToggle") == 12)
		{
			English.isOn = false;
			Chinese.isOn = false;
			Danish.isOn = false;
			French.isOn = false;
			German.isOn = false;
			Italian.isOn = false;
			Japanese.isOn = false;
			Dutch.isOn = false;
			Potugese.isOn = false;
			Russian.isOn = false;
			Arabic.isOn = false;
			Korean.isOn = false;
			Turkish.isOn = true;
			Spanish.isOn = false;
			Swedish.isOn = false;
			Vietnemese.isOn = false;
		}
		else if(PlayerPrefs.GetInt("LanguageToggle") == 13)
		{
			English.isOn = false;
			Chinese.isOn = false;
			Danish.isOn = false;
			French.isOn = false;
			German.isOn = false;
			Italian.isOn = false;
			Japanese.isOn = false;
			Dutch.isOn = false;
			Potugese.isOn = false;
			Russian.isOn = false;
			Arabic.isOn = false;
			Korean.isOn = false;
			Turkish.isOn = false;
			Spanish.isOn = true;
			Swedish.isOn = false;
			Vietnemese.isOn = false;
		}
		else if(PlayerPrefs.GetInt("LanguageToggle") == 14)
		{
			English.isOn = false;
			Chinese.isOn = false;
			Danish.isOn = false;
			French.isOn = false;
			German.isOn = false;
			Italian.isOn = false;
			Japanese.isOn = false;
			Dutch.isOn = false;
			Potugese.isOn = false;
			Russian.isOn = false;
			Arabic.isOn = false;
			Korean.isOn = false;
			Turkish.isOn = false;
			Spanish.isOn = false;
			Swedish.isOn = true;
			Vietnemese.isOn = false;
		}
		else if(PlayerPrefs.GetInt("LanguageToggle") == 15)
		{
			English.isOn = false;
			Chinese.isOn = false;
			Danish.isOn = false;
			French.isOn = false;
			German.isOn = false;
			Italian.isOn = false;
			Japanese.isOn = false;
			Dutch.isOn = false;
			Potugese.isOn = false;
			Russian.isOn = false;
			Arabic.isOn = false;
			Korean.isOn = false;
			Turkish.isOn = false;
			Spanish.isOn = false;
			Swedish.isOn = false;
			Vietnemese.isOn = true;
		}
	}
	
	public void ToggleEnglish()
	{
		PlayerPrefs.SetInt("LanguageToggle",0);
	}
	public void ToggleChinese()
	{
		PlayerPrefs.SetInt("LanguageToggle",1);
	}
	public void ToggleDanish()
	{
		PlayerPrefs.SetInt("LanguageToggle",2);
	}
	public void ToggleFrench()
	{
		PlayerPrefs.SetInt("LanguageToggle",3);
	}
	public void ToggleGerman()
	{
		PlayerPrefs.SetInt("LanguageToggle",4);
	}
	public void ToggleItalian()
	{
		PlayerPrefs.SetInt("LanguageToggle",5);
	}
	public void ToggleJapanese()
	{
		PlayerPrefs.SetInt("LanguageToggle",6);
	}
	public void ToggleDutch()
	{
		PlayerPrefs.SetInt("LanguageToggle",7);
	}
	public void TogglePotugese()
	{
		PlayerPrefs.SetInt("LanguageToggle",8);
	}
	public void ToggleRussian()
	{
		PlayerPrefs.SetInt("LanguageToggle",9);
	}
	public void ToggleArabic()
	{
		PlayerPrefs.SetInt("LanguageToggle",10);
	}
	public void ToggleKorean()
	{
		PlayerPrefs.SetInt("LanguageToggle",11);
	}
	public void ToggleTurkish()
	{
		PlayerPrefs.SetInt("LanguageToggle",12);
	}
	public void ToggleSpanish()
	{
		PlayerPrefs.SetInt("LanguageToggle",13);
	}
	public void ToggleSwedish()
	{
		PlayerPrefs.SetInt("LanguageToggle",14);
	}
	public void ToggleVietnemese()
	{
		PlayerPrefs.SetInt("LanguageToggle",15);
	}

}
