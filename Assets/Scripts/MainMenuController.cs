using UnityEngine;
using System;

public class MainMenuController : MonoBehaviour
{
    public PlayerSettings playerSettings;
    public TMPro.TextMeshProUGUI lengthText;

    public void SliderLengthOnChange(float value)
    {
        playerSettings.Length = Convert.ToInt32(value);
    }

    public void ApplicationQuit()
    {
        Debug.Log("Application.Quit()");
        Application.Quit();
    }

    private void Update()
    {
        lengthText.text = String.Format("{0}", playerSettings.Length);
    }
}
