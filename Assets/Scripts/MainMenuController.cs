using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class MainMenuController : MonoBehaviour
{
    public PlayerSettings playerSettings;
    public TMPro.TextMeshProUGUI lengthText;
    public Slider lengthSlider;
    public Image background;
    public Sprite backgroundLite;
    public Sprite backgroundDark;
    public Image lamp;
    public Sprite lampLite;
    public Sprite lampDark;

    private void Start()
    {
        lengthSlider.SetValueWithoutNotify(playerSettings.Length);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SliderLengthOnChange(float value)
    {
        playerSettings.Length = Convert.ToInt32(value);
    }

    public void LampClick()
    {
        playerSettings.LightOn = !playerSettings.LightOn;
    }

    public void ApplicationQuit()
    {
        Debug.Log("Application.Quit()");
        Application.Quit();
    }

    private void Update()
    {
        lengthText.text = String.Format("{0}", playerSettings.Length);

        if (playerSettings.LightOn)
        {
            background.sprite = backgroundLite;
            lamp.sprite = lampLite;
        } else
        {
            background.sprite = backgroundDark;
            lamp.sprite = lampDark;
        }
    }
}
