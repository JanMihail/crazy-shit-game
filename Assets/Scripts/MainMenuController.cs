using UnityEngine;
using System;

public class MainMenuController : MonoBehaviour
{
    public PlayerSettings playerSettings;
    public TMPro.TextMeshProUGUI textLength;

    public void SliderLengthOnChange(float value)
    {
        playerSettings.Length = Convert.ToInt32(value);
    }

    public void ButtonStartOnClick()
    {
        
    }

    private void Update()
    {
        textLength.text = String.Format("LENGTH: {0}", playerSettings.Length);
    }
}
